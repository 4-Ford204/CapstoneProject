var schedulesKendoUIManagement = (function () {

    var DOM = {
        ScheduleGrid: $("#schedulesGrid"),
        Popup: document.getElementById("popup")
    }

    var globalData = {
        baseURL: "../"
    }

    function bindEvents() { }

    function bindControls() { }

    function initSchedulesGrid() {
        DOM.ScheduleGrid.kendoGrid({
            dataSource: {
                transport: {
                    read: function (options) {
                        $.ajax({
                            url: globalData.baseURL + "Schedules/GetScheduleDTOs",
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
                            Name: { type: "string", editable: false },
                            Description: { type: "string", editable: false },
                            CreateDate: { type: "string", editable: false },
                            LastUpdateDate: { type: "string", editable: false },
                            AccountName: { type: "string", editable: false },
                            IsPublic: { type: "boolean", editable: false },
                            Status: { type: "boolean", editable: false }
                        }
                    }
                }
            },
            height: AutoFitHeight,
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
                    text: "Thêm Địa Điểm",
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
                    field: "Name",
                    headerTemplate: "<div class=\"kendo-grid-header\"><strong>Tên</strong></div>",
                    template: "<div class=\"kendo-grid-cell\">#:Name#</div>",
                    width: 150,
                    sortable: false,
                    filterable: false
                },
                {
                    field: "Description",
                    headerTemplate: "<div class=\"kendo-grid-header\"><strong>Mô Tả</strong></div>",
                    template: "<div class=\"kendo-grid-cell\">#:Description#</div>",
                    width: 150,
                    sortable: false,
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
                    sortable: false,
                    filterable: false
                },
                {
                    field: "AccountName",
                    headerTemplate: "<div class=\"kendo-grid-header\"><strong>Tên Người Tạo</strong></div>",
                    template: "<div class=\"kendo-grid-cell\">#:AccountName#</div>",
                    width: 150,
                    sortable: false,
                    filterable: false
                },
                {
                    field: "IsPublic",
                    headerTemplate: "<div class=\"kendo-grid-header\"><strong>Công Khai</strong></div>",
                    template: "<div class=\"kendo-grid-cell\"><div class=\"isPublicTemplate\"></div></div>",
                    width: 150,
                    sortable: false,
                    filterable: false
                },
                {
                    field: "Status",
                    headerTemplate: "<div class=\"kendo-grid-header\"><strong>Trạng Thái</strong></div>",
                    template: "<div class=\"kendo-grid-cell\"><div class=\"badgeTemplate\"></div></div>",
                    width: 150,
                    sortable: false,
                    filterable: false
                }
            ]
        });
    }

    function AutoFitHeight() {
        return document.documentElement.clientHeight -
            (
                document.querySelector(".main-header").clientHeight +
                document.querySelector(".main-footer").clientHeight
            );
    }

    function onDataBound(e) {
        var grid = this;

        grid.table.find("tr").each(function () {
            var dataItem = grid.dataItem(this);

            $(this).find(".isPublicTemplate").kendoBadge({
                themeColor: dataItem.IsPublic ? "success" : "error",
                text: dataItem.IsPublic ? "Công Khai" : "Không Công Khai"
            });

            $(this).find(".badgeTemplate").kendoBadge({
                themeColor: dataItem.Status ? "success" : "error",
                text: dataItem.Status ? "Hoạt Động" : "Ngưng Hoạt Động"
            });
        });
    }

    return {
        init: function () {
            initSchedulesGrid();
            bindEvents();
            bindControls();
        }
    }

})();

$(function () {
    schedulesKendoUIManagement.init();
});