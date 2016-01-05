$(document).ready(function () {
    $("#DeploymentDomains").change(function () {
        $.ajax({
            type: "Get",
            url: "/Json/GetCategories?laid=" + $('#DeploymentDomains').val(),
            success: function (data) {
                $("#Categories").empty();
                $(data).each(function () {
                    var selectmenuItem = $("<option />");
                    selectmenuItem.attr("value", this.Id).text(this.Name);
                    $("#Categories").append(selectmenuItem);
                });
            }
        });
    });

    $("#TestNow").click(function () {
        window.open("http://" + $('#DeploymentDomains :selected').text() + "/reports/add?category=" + $("#Categories").val());
    });

    $("#Generate").click(function () {
        $("#GeneratedLinks").val("");
        $.ajax({
            type: "Get",
            url: "/Json/GetCategory?laid=" + $('#DeploymentDomains').val() + "&categoryId=" + $("#Categories").val(),
            success: function (data) {
                $("#GeneratedLinks").val(JSON.stringify(data));
            }
        });
    });

    $("#GenerateAll").click(function () {
        $("#GeneratedLinks").val("");
        $.ajax({
            type: "Get",
            url: "/Json/GetCategories?laid=" + $('#DeploymentDomains').val(),
            success: function (data) {
                $("#GeneratedLinks").val(JSON.stringify(data));
            }
        });
    });
});