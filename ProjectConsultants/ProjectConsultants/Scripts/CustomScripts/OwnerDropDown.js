//Ajax Code for Owner Country State DropDown List
$(document).ready(function () {
    $("#ownerCountry").change(function () {
        $("#ownerState").empty();
        $.ajax({
            type: 'POST',

            // we are calling json method
            url: '/Project/GetOwnerStates',

            // here we get value of selected country and passing same value
            //as input to json method GetStates.
            data: { countryId: $("#ownerCountry").val() },
            dataType: 'json',
            success: function (ownerStates) {
                // states contains the JSON formatted list
                // of states passed from the controller

                $.each(ownerStates, function (i, state) {
                    $("#ownerState").append('<option value="' + state.Value + '">' +
                     state.Text + '</option>');
                    // here we are adding option for States

                });
            },
            error: function (ex) {
                alert('Failed to retrieve states.' + ex);
            }
        });
        return false;
    })
});
