﻿// Temporary Script for Under Maintenance pages
$(document).ready(function () {
    $(".showw").click(function () {
        $("#temprory").hide();
        $("#generalInfo").show();
    });
    $(".hidee").click(function () {
        $("#temprory").show();
        $("#generalInfo").hide();
        $("#temprory").html("<h2>Under Maintenance</h2>");
    });
});

//$(document).ready(function () {
//    $('li.navlist').click(function () {
//        $('li.navlist a').removeClass("active");
//        $(this).addClass("active");
//    });
//});

$(document).ready(function () {
    $('a.submitForm').click(function () {
        $('form#submitInformationForm').submit();
        //alert("Hello");
    });
});

$(document).ready(function () {

    $('#menu-icon').off().on().click(function () {
        var $this = $('.dropdown-menu');
        if ($this.hasClass("hidden")) {
            $this.removeClass("hidden").addClass("visible");
        } else {
            $this.removeClass("visible").addClass("hidden");
        }
    });
});

//accordion jquery 
$(document).ready(function(){
    $("#headerProject").mouseover(function () {
        $(".projectSubItem").slideDown("slow");
     });
    $("#headerProject").mouseout(function () {
        $(".projectSubItem").slideUp("slow");
     });
 });

//sb3 page script
$(document).ready(function () {

    $(".related").click(function () {
      
        $(".content").html("<h2>Related Content Under Process</h2>");

    });
});