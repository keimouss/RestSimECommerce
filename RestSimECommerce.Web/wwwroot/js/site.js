



//*Sur hover et click  des éléments du head-menu Categories*//
$(".ui-btns").mouseenter(
    function (data) {
        var idparentcateg = data.currentTarget.dataset.idparentcategorie;
        var togdiv = $('#dropdown-' + idparentcateg);
        //var ajaxResult = false;
        //var mondiv = $(data.currentTarget).children(".table-hover")[0];
        //var mondiv = togdiv.children(".table-hover")[0];

        $.ajax({
            type: "GET",
            dataType: 'html',
            url: "https://localhost:44393/Catalog/GetCategorie/" + idparentcateg,
            contentType: "application/x-www-form-urlencoded",
            success: (msg) => {
                $(togdiv).empty();
                if ($(msg).length > 0) {
                    $(togdiv).append(msg);
                    ajaxResult = true;
                    //console.log(ajaxResult);
                    //$(mondiv).append(msg);
                    //console.log(togdiv);
                }
            },
            error:
                (error) => {
                    console.log("error", error);
                }
        });

       
            $('#dropdown-' + idparentcateg).show();
        
           
       
      
    })
    .mouseleave(function (data) {
        var idparentcateg = data.currentTarget.dataset.idparentcategorie;
        $('#dropdown-' + idparentcateg).hide();
    });

$('.ui-btn1').click(function (data) {
    var idparentcateg = data.currentTarget.dataset.idparentcategorie;
    $.ajax({
        type: "GET",
        dataType: 'html',
        url: "https://localhost:44393/Catalog/GetCategorie2/" + idparentcateg,
        async: true,
        contentType: "application/x-www-form-urlencoded",
        success: (msg) => {
            $('#affichageProduct').empty();
            if ($(msg).length > 0) {
                $('#affichageProduct').append(msg);
                //$(mondiv).append(msg);
                //console.log(togdiv);
            }
        },
        error:
            (error) => {
                console.log("error", error);
            }
    });
}); //* Fin traitement élts head-menu categories

//*Affichage du contenu du panier sur l'entré et sortie de la sourie*/
$("#viewlepanier").mouseenter(function () {

    //console.log("Opened")
    //$("#flyout-panier").attr("hidden", false);
    $('.modal').modal('show');
})
    .mouseleave(function () {
        $('.modal').modal('hide');
        //$("#flyout-panier").attr("hidden", true);
    });//***********Fin************//
