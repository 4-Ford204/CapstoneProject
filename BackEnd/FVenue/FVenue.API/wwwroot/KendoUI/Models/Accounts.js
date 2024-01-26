var accountsKendoUIManagement = (function () {

    var DOM = {
        AccountsGrid: $("#accountsGrid"),
        Popup: document.getElementById("popup")
    }

    var globalData = {
        baseURL: "../"
    }

    function bindEvents() {
    }

    function bindControls() { }

    function initAccountsGrid() {
        DOM.AccountsGrid.kendoGrid({
            dataSource: {
                transport: {
                    read: function (options) {
                        $.ajax({
                            url: globalData.baseURL + "Accounts/GetAccountDTOs",
                            type: "GET",
                            contentType: "application/json; charset=utf-8",
                            dataType: "JSON",
                            success: function (result) {
                                options.success(result);
                            },
                            error: function (result) {
                                options.error(result);
                            }
                        });
                    }
                },
                batch: true,
                autoSync: true,
                schema: {
                    model: {
                        id: "Id",
                        fields: {
                            Id: { type: "number", editable: false, nullable: false },
                            Email: { type: "string", editable: false, nullable: false },
                            Image: { type: "string", editable: false },
                            PhoneNumber: { type: "string", editable: false },
                            CreateDate: { type: "string", editable: false },
                            LastUpdateDate: { type: "string", editable: false },
                            Status: { type: "boolean", editable: false },
                            RoleName: { type: "string", editable: false },
                            FirstName: { type: "string", editable: false },
                            LastName: { type: "string", editable: false },
                            FullName: { type: "string", editable: false },
                            Gender: { type: "boolean", editable: false },
                            BirthDay: { type: "string", editable: false },
                            LoginVia: { type: "number", editable: false },
                            IsEmailConfirmed: { type: "boolean", editable: false }
                        }
                    }
                }
            },
            height: 680,
            pageable: {
                pageSize: 10,
                refresh: true,
                serverPaging: true,
                serverFiltering: true,
                serverSorting: true,
            },
            sortable: true,
            navigatable: true,
            resizable: true,
            reorderable: true,
            scrollable: true,
            filterable: true,
            dataBound: onDataBound,
            toolbar: [
                {
                    name: "create",
                    text: "Thêm Tài Khoản",
                },
                {
                    name: "cancel",
                    text: "Đổi Trạng Thái",
                }
            ],
            columns: [
                {
                    selectable: true,
                    width: 50,
                    headerAttributes: {
                        "class": "kendo-checkbox"
                    },
                    attributes: {
                        "class": "kendo-checkbox"
                    }
                },
                {
                    field: "Email",
                    headerTemplate: "<div class=\"kendo-grid-header\"><strong>Email Người Dùng</strong></div>",
                    template:
                        "<div style=\"display: flex; flex-direction: row; align-items: center;\">" +
                        "<div class=\"kendo-cell-photo\" style=\"background-image: url(#:Image#);\"></div>" +
                        "<div class=\"kendo-cell-name\">#:Email#</div>" +
                        "</div>",
                    width: 300,
                    sortable: false,
                    filterable: {
                        extra: false,
                        showOperators: false,
                        messages: {
                            info: "",
                            filter: "Lọc",
                            clear: "Xoá"
                        },
                        operators: {
                            string: {
                                contains: "Bao Gồm",
                                doesnotcontain: "Không Bao Gồm"
                            }
                        }
                    }
                },
                {
                    field: "PhoneNumber",
                    headerTemplate: "<div class=\"kendo-grid-header\"><strong>Số Điện Thoại</strong></div>",
                    template: "<div class=\"kendo-grid-cell\">#:PhoneNumber#</div>",
                    width: 150,
                    sortable: true,
                    filterable: false
                },
                {
                    field: "CreateDate",
                    headerTemplate: "<div class=\"kendo-grid-header\"><strong>Ngày Tạo</strong></div>",
                    template: "<div class=\"kendo-grid-cell\">#:CreateDate#</div>",
                    width: 150,
                    sortable: false,
                    filterable: false
                },
                {
                    field: "LastUpdateDate",
                    headerTemplate: "<div class=\"kendo-grid-header\"><strong>Ngày Cập Nhật</strong></div>",
                    template: "<div class=\"kendo-grid-cell\">#:LastUpdateDate#</div>",
                    width: 150,
                    filterable: false
                },
                {
                    field: "Status",
                    headerTemplate: "<div class=\"kendo-grid-header\"><strong>Trạng Thái</strong></div>",
                    template: "<div class=\"kendo-grid-cell\"><div class=\"badgeTemplate\"></div></div>",
                    width: 150
                },
                {
                    field: "RoleName",
                    headerTemplate: "<div class=\"kendo-grid-header\"><strong>Vai trò</strong></div>",
                    template: "<div class=\"kendo-grid-cell\">#:RoleName#</div>",
                    width: 150,
                    filterable: false
                },
                {
                    field: "FirstName",
                    headerTemplate: "<div class=\"kendo-grid-header\"><strong>Tên</strong></div>",
                    template: "<div class=\"kendo-grid-cell\">#:FirstName#</div>",
                    width: 150,
                    filterable: false
                },
                {
                    field: "LastName",
                    headerTemplate: "<div class=\"kendo-grid-header\"><strong>Họ</strong></div>",
                    template: "<div class=\"kendo-grid-cell\">#:LastName#<div>",
                    width: 150,
                    filterable: false
                },
                {
                    field: "FullName",
                    headerTemplate: "<div class=\"kendo-grid-header\"><strong>Tên Đầy Đủ</strong></div>",
                    template: "<div class=\"kendo-grid-cell\">#:FullName#<div>",
                    width: 150,
                    filterable: false
                },
                {
                    field: "Gender",
                    headerTemplate: "<div class=\"kendo-grid-header\"><strong>Giới tính</strong></div>",
                    template: "<div class=\"kendo-grid-cell\"><div class=\"genderTemplate\"></div></div>",
                    width: 150,
                    filterable: false
                },
                {
                    field: "BirthDay",
                    headerTemplate: "<div class=\"kendo-grid-header\"><strong>Ngày sinh</strong></div>",
                    template: "<div class=\"kendo-grid-cell\">#:BirthDay#</div>",
                    width: 150,
                    filterable: false
                },
                {
                    field: "LoginVia",
                    headerTemplate: "<div class=\"kendo-grid-header\"><strong>LoginVia</strong></div>",
                    template: "<div class=\"kendo-grid-cell\">#:LoginVia#</div>",
                    width: 150,
                    filterable: false
                },
                {
                    field: "IsEmailConfirmed",
                    headerTemplate: "<div class=\"kendo-grid-header\"><strong>IsEmailConfirmed</strong></div>",
                    template: "<div class=\"kendo-grid-cell\">#:IsEmailConfirmed#</div>",
                    width: 150,
                    filterable: false
                },
                {
                    template:
                        "<div class=\"kendo-grid-cell\">" +
                        "<button type=\"button\" class=\"btn btn-info kendo-grid-btn\">Cập Nhật</button>" +
                        "</div>",
                    width: 100
                },
            ]
        });
    }

    function onDataBound(e) {
        var grid = this;

        grid.table.find("tr").each(function () {
            var dataItem = grid.dataItem(this);
            var themeColor = dataItem.Status ? "success" : "error";
            var text = dataItem.Status ? "Hoạt Động" : "Ngưng Hoạt Động";

            $(this).find(".badgeTemplate").kendoBadge({
                themeColor: themeColor,
                text: text,
            });

            $(this).find(".genderTemplate").html(
                dataItem.Gender ? "<i class=\"fa-solid fa-person\" style=\"color: #74C0FC;\"></i>" : "<i class=\"fa-solid fa-person-dress\" style=\"color: #74C0FC;\"></i>"
            );
        });
    }

    return {
        init: function () {
            initAccountsGrid();
            bindEvents();
            bindControls();
        }
    }

})();

$(function () {
    accountsKendoUIManagement.init();
});
