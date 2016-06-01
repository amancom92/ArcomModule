
$(document).ready(function () {

    //$(".showw").click(function () {
    //    $("#temprory").hide();
    //    $("#generalInfo").show();
    //});

    //hide and show for Under maintenance pages
    $(".showw").click(function () {
        $("#temprory").hide();
        $("#generalInfo").show();
    });


    $(".hidee").click(function () {
        $("#temprory").show();
        $("#generalInfo").hide();
        $("#temprory").html("<h2>Under Maintenance</h2>");

        $("#generalInfo").hide();
        $("#participants").hide();
    });  


$(".hideenp").click(function () {  
    $("#btnci").hide();
    $("#btncp").hide();
    $("#btndi").hide();
    $("#btnpt").hide();
    $("#btnsf").show();
    $("#generalInfo").hide();
    $("#participants").show();
    $("#temprory").hide();

});
$(".hideeng").click(function () {
    $("#btnsf").hide();
    $("#btnci").show();
    $("#btncp").show();
    $("#btndi").show();
    $("#btnpt").show();
    $("#generalInfo").show();
    $("#temprory").hide();
    $("#participants").hide();
});

    // menu hide and show
    $('.menuDropdown').off().on().click(function () {
        var $this = $('.dropdown-menu');
        if ($this.hasClass("hidden")) {
            $this.removeClass("hidden").addClass("visible");
        } else {
            $this.removeClass("visible").addClass("hidden");
        }
    });

    // submit form
    $('a.submitForm').click(function () {
        $('form#submitInformationForm').submit();
    });

    //Accordion jquery 
    $("#headerProject").off().click(function () {
        $(".projectSubItem").slideToggle("slow");
        $(".toolsSubItem").hide();
        $(".settingsSubItem").hide();
    });

    $("#headerTools").off().click(function () {
        $(".toolsSubItem").slideToggle("slow");
        $(".projectSubItem").hide();
        $(".settingsSubItem").hide();
    });

    $("#headerSettings").off().click(function () {
        $(".settingsSubItem").slideToggle("slow");
        $(".toolsSubItem").hide();
        $(".projectSubItem").hide();
    });

    //sb3 page script
    $(".related").click(function () {
        $(".content").html("<h2>Related Content Under Process</h2>");
    });


});




