$(document).ready(function () {
    $('#btnRegister').click(function () {
        $.ajax({
            url: '/api/account/register',
            method: 'POST',
            data: {
                email: $('#username').val(),
                password: $('#password').val(),
                confirmPassword: $('#confirmpassword').val(),
            },
            success: function () {
                alert("Registration successful");
            },
            error: function (err) {
                alert(err.responseText);
            }
        });
    });
});

