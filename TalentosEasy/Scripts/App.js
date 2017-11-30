//JQuery
jQuery.noConflict();
$(document).ready(function () {

    //controle dos slides
    setTimeout(function () { $('.carousel').carousel('pause'); }, 1800);
    $("#btnContinuar, #btnContinuar2, #btnContinuar3, #btnContinuar4, #btnContinuar5").on('click', function () {      
        $('.carousel').carousel('next');
        $('.carousel').carousel('pause');
    });

    //Direciona pagina inicial
    $("#imgEasy").on('click', function () {
        $('.carousel').carousel(0);
        $('.carousel').carousel('pause');
    });

    //Controla cores 
    $('.btnList button').on('click', function (tg, ev) {
        $('.btnList button').each(function (ta, ev) {
            if (ev.name == tg.currentTarget.name) $(ev).removeClass('selected');
        })
        $(tg.currentTarget).addClass('selected');
    });


}); 

//Angular
var app = angular.module("myApp", []);
app.controller("contentCtrl", function ($scope, $http) {

    var carregarTalentos = function () {
        $http.get("/api/Talento").then(function (data) {
            $scope.talentos = data.data;
        });
    }

    var marcarConhecimentos = function (ConhecimentosTalento) {
        // console.log(ConhecimentosTalento);
        $(ConhecimentosTalento).each(function (idx, val) {
            $('.btnList button').each(function (ta, ev) {
                if (ev.name == val.NomeConhecimento && ev.value == val.NotaConhecimento) {
                    //console.log(ev);
                    $(ev).addClass('selected');
                }
            });
        });
    }

    $scope.editTalento = function (talento) {
        $scope.talento = talento;
        marcarConhecimentos(talento.ConhecimentosTalento);
        $('#btnEditar').removeAttr('hidden');
        $('#btnNovo').removeAttr('hidden');
    }

    $scope.editarTalento = function () {
        $('.carousel').carousel('next');
        $('.carousel').carousel('pause');
    }

    $scope.novoTalento = function () {
        $scope.talento = [];
        $('#btnEditar').attr("hidden", "true");
        $('#btnNovo').attr("hidden", "true");
    }

    $scope.deleteTalento = function (idTalento) {
        var talentos = [];
        angular.copy($scope.talentos, talentos);
        //console.log(idTalento);
        $http.delete("/api/Talento/" + idTalento).then(function (data) {

        });
        $scope.talentos = talentos.filter(function (tal) {
            if (tal.IdTalento != idTalento) {
                return tal;
            }
        });

    }
    carregarTalentos();

    //Testes
    $scope.mostrar = function (valor) {
        console.log(valor);
    }

    //seta conhecimentos gerando lista atualizando por click
    $scope.setConhecimento = function (talento, NomeConhecimento, NotaConhecimento) {
        var titulo = NomeConhecimento;
        if (talento.ConhecimentosTalento != undefined) {

            var exist = talento.ConhecimentosTalento.some(function (conhecimento, vs) {
                if (talento.ConhecimentosTalento[vs].NomeConhecimento == NomeConhecimento)
                    talento.ConhecimentosTalento[vs].NotaConhecimento = NotaConhecimento;
                var conh = conhecimento.NomeConhecimento;
                return titulo == conh;
            });
            if (!exist)
                talento.ConhecimentosTalento.push({ NomeConhecimento: NomeConhecimento, NotaConhecimento: NotaConhecimento });
        }
        else {
            talento.ConhecimentosTalento = [];
            talento.ConhecimentosTalento.push({ NomeConhecimento: NomeConhecimento, NotaConhecimento: NotaConhecimento });
        }
    }

    //Salvar cadastro
    $scope.finalizarCadastro = function (talento) {

        if (talento.IdTalento == undefined) {
            $http.post("/api/Talento", talento).then(function (data) {
                $('.carousel').carousel(0);
                $('.carousel').carousel('pause');
                $scope.talentos.push(talento);
            });
        } else {
            $http.put("/api/Talento/" + talento.IdTalento, talento).then(function (data) {
                $('.carousel').carousel(0);
                $('.carousel').carousel('pause');
            });
        }
        $scope.talento = [];
        $('#btnEditar').attr("hidden", "true");
        $('#btnNovo').attr("hidden", "true");
    }

});

app.directive('ngConfirmClick', [
    function () {
        return {
            priority: -1,
            restrict: 'A',
            scope: { confirmFunction: "&mwConfirmClick" },
            link: function (scope, element, attrs) {
                element.bind('click', function (e) {
                    // message defaults to "Are you sure?"
                    var message = attrs.mwConfirmClickMessage ? attrs.mwConfirmClickMessage : "Are you sure?";
                    // confirm() requires jQuery
                    if (confirm(message)) {
                        scope.confirmFunction();
                    }
                });
            }
        }
    }
]);