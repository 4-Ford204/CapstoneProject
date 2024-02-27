var homeManagement = (function () {

    var DOM = {
        SubCategoryRequestApprovedButton: $("#subCategoryRequestApproved"),
        SubCategoryRequestRejectedButton: $("#subCategoryRequestRejected"),
    }

    var globalData = {
        baseURL: "../"
    }

    function bindEvents() {
        SubCategoryRequestApprovedButton();
        SubCategoryRequestRejectedButton();
    }

    function bindControls() { }

    function SubCategoryRequestApprovedButton() {
        DOM.SubCategoryRequestApprovedButton.on("click", (function () {
            var ids = [];
            $("input[id^=\"subCategoryRequest\"]").each(function (index, element) {
                if (element.checked) ids.push(element.value);
            });
            $.ajax({
                url: globalData.baseURL + "SubCategories/UpdateSubCategoryRequestStatus",
                type: "POST",
                contentType: "application/json; charset=utf-8",
                dataType: "JSON",
                data: {
                    ids: ids,
                    status: "Approved"
                },
                success: function (result) {
                    console.log(result);
                },
                error: function (result) {
                    console.log(result);
                }
            });
        }));
    }

    function SubCategoryRequestRejectedButton() {
        DOM.SubCategoryRequestRejectedButton.on("click", (function () {

        }));
    }

    return {
        init: function () {
            bindEvents();
            bindControls();
        }
    }

})();

$(function () {
    homeManagement.init();
});