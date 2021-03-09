$(function () {
    $("#btnQuery").click(function () {
        var serviceCodeId= $("#txtFollow").val()
        $.ajax({
            url: "/query-service",
            method: "post",
            datatype: "json",
            data: { serviceCode: serviceCodeId },
            success: function (response) {
                $("#txtFullName").val(response.serviceDetailsInfo.fullName);
                $("#txtBrand").val(response.serviceDetailsInfo.brand);
                $("txtModel").val(response.serviceDetailsInfo.model);
                $("#txtFault").val(response.serviceDetailsInfo.faultId);
                $("#txtDeviceStatus").val(response.serviceDetailsInfo.deviceStatusId);
                $("#hfServiceCode").val(response.serviceDetailsInfo.serviceCode);
            }
        });
        $("#divServiceDetailsForm").modal("show");
    });

    $("#sendMessage").click(function () {
        var vm = {
            FullName: $("#txtFullName").val(),
            Email: $("#txtEmail").val(),
            Messages: $("#txtMessage").val()
        };
        $.ajax({
            url: "/customer-send-message",
            method: "post",
            datatype: "json",
            data: { vm: vm },
            success: function (resp) {
                if (resp.result) {
                    Swal.fire({
                        icon: 'success',
                        title: 'İşlem Başarılı',
                        text: resp.message
                    }).then((result) => {
                        if (result.isConfirmed) {
                            window.location.reload();
                        }
                    });
                }
                else {
                    Swal.fire({
                        icon: 'error',
                        title: 'Hata!!!',
                        text: resp.message
                    })
                }
            }
        })
    });
    
});