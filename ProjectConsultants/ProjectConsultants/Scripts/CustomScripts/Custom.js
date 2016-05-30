
$(document).ready(function () {
    //hide and show for Under maintenance pages
    $(".showw").click(function () {
        $("#temprory").hide();
        $("#generalInfo").show();
    });

    $(".hidee").click(function () {
        $("#temprory").show();
        $("#generalInfo").hide();
        $("#temprory").html("<h2>Under Maintenance</h2>");
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

});


//$(document).ready(function () {
//    $('li.navlist').click(function () {
//        $('li.navlist a').removeClass("active");
//        $(this).addClass("active");
//    });
//});

//sb3 page script
$(document).ready(function () {

    $(".related").click(function () {
      
        $(".content").html("<h2>Related Content Under Process</h2>");

    });
});

