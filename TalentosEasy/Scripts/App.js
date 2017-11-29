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
app.controller("contentCtrl", function ($scope) {
    $scope.talentos = [];

    //Testes
    $scope.mostrar = function (talento) {
        console.log(talento);
    }

    //seta conhecimentos gerando lista atualizando por click
    $scope.setConhecimento = function (talento, conhecimento, nota) {
        var titulo = conhecimento;
        if (talento.conhecimentosTalento != undefined) {
            var exist = talento.conhecimentosTalento.some(function (conhecimento, vs) {
                talento.conhecimentosTalento[vs].nota = nota;
                var conh = conhecimento.conhecimento;
                return titulo == conh;
            });
            if (!exist)
                talento.conhecimentosTalento.push({ conhecimento: conhecimento, nota: nota });
        }
        else {
                talento.conhecimentosTalento = [];
                talento.conhecimentosTalento.push({ conhecimento: conhecimento, nota: nota });
        }
       
    }

    
});
