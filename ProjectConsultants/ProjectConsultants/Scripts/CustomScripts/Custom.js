// Temporary Script for Under Maintenance pages
$(document).ready(function () {
    //$(".showw").click(function () {
    //    $("#temprory").hide();
    //    $("#generalInfo").show();
    //});
    $(".hidee").click(function () {
        $("#temprory").show();
        $("#generalInfo").hide();
        $("#temprory").html("<h2>Under Maintenance</h2>");
        $("#generalInfo").hide();
        $("#participants").hide();
    });  
});
$(document).ready(function () {
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
