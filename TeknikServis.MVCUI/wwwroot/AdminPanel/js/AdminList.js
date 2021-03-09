
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

    $.validator.addMethod("passwordCheck", function (value) {
        return /^[A-Za-z0-9\d=!\-@._*]*$/.test(value) // consists of only these
            && /[a-z]/.test(value) // has a lowercase letter
            && /\d/.test(value) // has a digit
    });

    $.validator.addMethod("roleCheck", function (contentToControl) {
        return contentToControl != "-1";
    });

    $("#btnSave").click(function () {
        $("#frmNewAdmin").validate({
            rules: {
                txtEmail: {
                    required: true,
                    email: true
                },
                txtPassword: {
                    required: true,
                    minlength: 8,
                    passwordCheck:true
                },
                txtFullName: {
                    required: true,
                    minlength: 2
                },
                ddlRoleList: {
                    roleCheck:true
                }
            },
            messages: {
                txtEmail: {
                    required: "Email zorunlu bir alandır",
                    email: "Girdiğiniz email adresi geçerli bir formatta olmalıdır"
                },
                txtPassword: {
                    required: "Şifre zorunludur",
                    minlength: "Şifre En az 8 karakter olmalıdır",
                    passwordCheck:"Şifrede en az 1 küçük harf ve en az 1 rakam olmalıdır"
                },
                txtFullName: {
                    required: "Ad Soyad zorunludur",
                    minlength: "Ad Soyad En az 2 karakter olmalıdır"
                },
                ddlRoleList: {
                    roleCheck: "Yöneticinin rolü seçilmelidir"
                }
            }
        });

        var isFormValid = $("#frmNewAdmin").valid();
        if (isFormValid) {
            var formData = new FormData();
            var file = $("#fuPhoto")[0].files[0];
            formData.append("photo", file);

            $.ajax({
                url: "/admin-photo-upload",
                method: "post",
                data: formData,
                contentType: false,
                processData: false,
                success: function (response) {
                    if (response.result) {
                        var vm = {
                            Email: $("#txtEmail").val(),
                            Password: $("#txtPassword").val(),
                            FullName: $("#txtFullName").val(),
                            RoleId: $("#ddlRoleList").val(),
                            IsActive: $("#gridCheck").is(":checked"),
                            Photo: response.photoPath
                        };

                        $.ajax({
                            url: "/save-new-admin",
                            method: "post",
                            datatype: "json",
                            data: { vm: vm },
                            success: function (resp) {
                                if (resp.result) {
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
                                        text: response.message
                                    })
                                }
                            }
                        });


                    }
                    else {
                        Swal.fire({
                            icon: 'error',
                            title: 'Hata!!!',
                            text: response.message
                        })
                    }
                }
            });
        }

    });

    // EDIT BUTONUNA BASILDIĞINDA CLIENT DA ZATEN VAR OLAN VERİYİ OKUYUP MODAL A BASMAK
    //$(".btnEdit").click(function () {

    //    var tr = $(this).parent().parent();
    //    var tdFullName = tr.find("td:nth-child(2)");
    //    var tdEmail = tr.find("td:nth-child(3)");

    //    $("#txtFullNameUpdate").val(tdFullName.text());
    //    $("#txtEmailUpdate").val(tdEmail.text());

    //    $("#divUpdateAdminForm").modal("show");
    //});
    //------------------------------------------------------------------------------

    $(".btnEdit").click(function () {
        var adminId = $(this).attr("adminid");

        $.ajax({
            url: "/admin-details",
            type: "post",
            datatype: "json",
            data: { id: adminId },
            success: function (response) {
                $("#txtFullNameUpdate").val(response.adminInfo.fullName);
                $("#txtPasswordUpdate").val(response.adminInfo.password);
                $("#txtEmailUpdate").val(response.adminInfo.email);
                $("#ddlRoleListUpdate").val(response.adminInfo.roleId);
                $("#gridCheckUpdate").prop('checked', response.adminInfo.isActive);
                $("#imgAdminPhotoUpdate").attr("src", response.adminInfo.photo);
                $("#hfAdminIdUpdate").val(response.adminInfo.id);
            }
        });

        $("#divUpdateAdminForm").modal("show");
    });

    $("#btnPhotoChange").click(function () {
        $("#fuPhotoUpdate").toggle();
    });

    $("#btnSaveUpdate").click(function () {
        var formData = new FormData();
        var file = $("#fuPhotoUpdate")[0].files[0];
        formData.append("photo", file);

        $.ajax({
            url: "/admin-photo-update",
            method: "post",
            data: formData,
            contentType: false,
            processData: false,
            success: function (resp) {
                if (resp.result) {
                    var vm = {
                        Id: $("#hfAdminIdUpdate").val(),
                        Email: $("#txtEmailUpdate").val(),
                        Password: $("#txtPasswordUpdate").val(),
                        FullName: $("#txtFullNameUpdate").val(),
                        RoleId: $("#ddlRoleListUpdate").val(),
                        IsActive: $("#gridCheckUpdate").is(":checked"),
                        Photo: resp.photoPath

                    };
                    $.ajax({
                        url: "/update-admin",
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
                    });
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
                var clickedA = $(this);

                var aId = clickedA.attr("adminid");
                $.ajax({
                    url: "/delete-admin",
                    method: "post",
                    datatype: "json",
                    data: { id: aId },
                    success: function (respponse) {
                        if (respponse.result) {
                            var tr = clickedA.parent().parent();
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
});
