$(function () {
    $('#tblAdminList').DataTable({
        "paging": true,
        "lengthChange": true,
        "searching": true,
        "ordering": true,
        "info": true,
        "autoWidth": true,
        "responsive": true,
    });
    $("#btnSave").click(function () {
        var vm = {
            FullName: $("#txtFullName").val(),
            Brand: $("#txtBrand").val(),
            Model: $("#txtModel").val(),
            FaultId: $("#ddlFaultList").val(),
            DeviceStatusId: $("#ddlDeviceStatusList").val(),
            CustomerTypeId: $("#ddlCustomerTypeList").val(),
            UnitPrice: $("#txtUnitPrice").val()
        };
        $.ajax({
            url: "/save-new-service",
            method: "post",
            datatype: "json",
            data:{ vm: vm },
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
        });

    });
    $(".btnEdit").click(function () {
        var serviceId = $(this).attr("serviceid");
        $.ajax({
            url: "/details-service",
            type: "post",
            datatype: "json",
            data: { id: serviceId },
            success: function (resp) {
                $("#txtFullNameUpdate").val(resp.serviceInfo.fullName);
                $("#txtBrandUpdate").val(resp.serviceInfo.brand);
                $("#txtModelUpdate").val(resp.serviceInfo.model);
                $("#ddlFaultListUpdate").val(resp.serviceInfo.faultId);
                $("#ddlDeviceStatusListUpdate").val(resp.serviceInfo.deviceStatusId);
                $("#hfServiceIdUpdate").val(resp.serviceInfo.id);
                $("#txtUnitPRiceUpdate").val(resp.serviceInfo.unitPrice);
                $("#ddlCustomerTypeListUpdate").val(resp.serviceInfo.customerTypeId);
            }
        });
        $("#divUpdateServiceForm").modal("show");
    });

    $("#btnSaveUpdate").click(function () {
        var vm = {
            Id: $("#hfServiceIdUpdate").val(),
            FullName: $("#txtFullNameUpdate").val(),
            Brand: $("#txtBrandUpdate").val(),
            Model: $("#txtModelUpdate").val(),
            FaultId: $("#ddlFaultListUpdate").val(),
            DeviceStatusId: $("#ddlDeviceStatusListUpdate").val(),
            CustomerTypeId: $("#ddlCustomerTypeListUpdate").val(),
            UnitPrice: $("#txtUnitPRiceUpdate").val()
        };
        $.ajax({
            url: "/update-service",
            method: "post",
            datatype: "json",
            data: { vm: vm },
            success: function (response) {
                if (response.result) {
                    Swal.fire({
                        icon: 'success',
                        title: 'İşlem Başarılı',
                        text: response.message
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
        });
    });

    $(".btnDelete").click(function () {
        Swal.fire({
            title: 'Are you sure?',
            text: "You won't be able to revert this!",
            icon: 'warning',
            showCancelButton: true,
            confirmButtonColor: '#3085d6',
            cancelButtonColor: '#d33',
            confirmButtonText: 'Yes, delete it!'
        }).then((result) => {
            if (result.isConfirmed) {
                var clickedS = $(this);

                var sId = clickedS.attr("serviceid");
                $.ajax({
                    url: "/delete-service",
                    method: "post",
                    datatype: "json",
                    data: { id: sId },
                    success: function (respponse) {
                        if (respponse.result) {
                            var tr = clickedS.parent().parent();
                            tr.remove();

                            Swal.fire(
                                'Deleted!',
                                'Your file has been deleted.',
                                'success'
                            )
                        }

                    }
                });



            }
        })
    });

    $('#tblServiceList').DataTable({
        "paging": true,
        "ordering": false,
        "searching": true,
        "language": {
            "sDecimal": ",",
            "sEmptyTable": "Tabloda herhangi bir veri mevcut değil",
            "sInfo": "_TOTAL_ kayıttan _START_ - _END_ arasındaki kayıtlar gösteriliyor",
            "sInfoEmpty": "Kayıt yok",
            "sInfoFiltered": "(_MAX_ kayıt içerisinden bulunan)",
            "sInfoPostFix": "",
            "sInfoThousands": ".",
            "sLengthMenu": "Sayfada _MENU_ kayıt göster",
            "sLoadingRecords": "Yükleniyor...",
            "sProcessing": "İşleniyor...",
            "sSearch": "Ara:",
            "sZeroRecords": "Eşleşen kayıt bulunamadı",
            "oPaginate": {
                "sFirst": "İlk",
                "sLast": "Son",
                "sNext": "Sonraki",
                "sPrevious": "Önceki"
            },
            "oAria": {
                "sSortAscending": ": artan sütun sıralamasını aktifleştir",
                "sSortDescending": ": azalan sütun sıralamasını aktifleştir"
            },
            "select": {
                "rows": {
                    "_": "%d kayıt seçildi",
                    "0": "",
                    "1": "1 kayıt seçildi"
                }
            }
        }
    });
});