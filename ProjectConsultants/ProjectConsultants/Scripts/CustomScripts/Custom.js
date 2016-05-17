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

$(document).ready(function () {
    $('ul li a').click(function () {
        $('li a').removeClass("active");
        $(this).addClass("active");
    });
});