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
