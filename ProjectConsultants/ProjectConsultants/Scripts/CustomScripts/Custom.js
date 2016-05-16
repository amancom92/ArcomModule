// Temporary Script for Under Maintenance pages
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

