var saveApplication = function () {
    var name = $("#txtName").val();
    var city = $("#ddlCity").val();
    var state = $("#ddlState").val();
    var address = $("#txtAddress").val();
    var pincode = $("#txtPincode").val();
    var mobileno = $("#txtMobileNo").val();
    var model = { Name: name, City: city, State: state, Address: address, Pincode: pincode, MobileNo: mobileno };

    $.ajax({
        url: "/Application/saveApplication",
        method: "Post",
        data: JSON.stringify(model),
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        success: function (response) {
            alert("successfull");
        }
    })
};