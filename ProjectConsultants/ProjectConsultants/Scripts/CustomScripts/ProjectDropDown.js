//Ajax Code for Project Country State DropDown List
$(document).ready(function () {
    $("#Country").change(function () {
        $("#State").empty();
        $.ajax({
            type: 'POST',

            // we are calling json method
            //url: '/Project/GetStates' + countryId,

            url: '/Project/GetStates',
            // here we get value of selected country and passing same value
            //as input to json method GetStates.
            data: { Country: $("#Country").val() },
            dataType: 'json',
            success: function (states) {
                // states contains the JSON formatted list
                // of states passed from the controller

                $.each(states, function (i, state) {
                    $("#State").append('<option value="' + state.Value + '">' +
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

