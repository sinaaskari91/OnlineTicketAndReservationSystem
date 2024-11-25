// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function createProvinceWithAjax(e) {
    let provinceName = $("#provinceName").val();
    let data = { nmae: provinceName };
    if (e.keycode == 13 || e.type == "click") {
        e.preventDefault();
        $.ajax({
            type: "post",
            url: '/Home/CreateProvice',
            contenttype: 'application/json',
            data: JSON.stringify(data),
            success: function (response) {
                if (response) {
                    if (responce.result) {
                        showMessage('success', "درج استان با موفقیت انجام شد", 'success');
                        setTimeout(() => {
                            reloadNewIndex();
                        }, 1500)
                    }
                    else
                    {
                        showMessage('Error', response.errorMessage[0], 'error');
                    }
                }
                else {

                    showMessage('Error', "Tank for ...", 'error');

                }
            }

        })
    }
}
function showMessage(title, text, theme) {
    window.createNotification({
        closeOnClick: true,
        displayCloseButton: false,
        positionClass:'nfc-top-right',
        showDuration: 3000,
        theme:theme!==''?theme:'success'
    })({
        title: title !== '' ? title : 'اعلان',
        message:decodeURI(text)
    })
}


                  
       