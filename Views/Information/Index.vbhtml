@ModelType IEnumerable(Of WebBaoHiem.Information)
@Code
ViewData("Title") = "Index"
Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>THÔNG TIN KHÁCH HÀNG MUA BẢO HIỂM</h2>

<p>
    @Html.ActionLink("Thêm mới", "Create")
</p>
<div class="row">
    <input id="txtInput"/>
    <button id="btnSearch" class="btn btn-primary">Tìm kiếm</button>
</div>
<table class="table">
    <tr>
        <th>
            
            @Html.DisplayNameFor(Function(model) model.TenKhachHang)
        </th>
        <th>
            
            @Html.DisplayNameFor(Function(model) model.CreateDay)
        </th>
        <th>
            
            @Html.DisplayNameFor(Function(model) model.Address)
        </th>
        <th>
            
            @Html.DisplayNameFor(Function(model) model.LoaiBaoHiem.LoaiBaoHiem1)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.TenKhachHang)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.CreateDay)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Address)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.LoaiBaoHiem.LoaiBaoHiem1)
        </td>
        <td>
            @Html.ActionLink("Sửa", "Edit", New With {.id = item.Id}) |
            @Html.ActionLink("Chi tiết", "Details", New With {.id = item.Id}) |
            @Html.ActionLink("Xoá", "Delete", New With {.id = item.Id})
        </td>
    </tr>
Next

</table>
<script>
    $('#btnSearch').on('click', function () {
        var giatrinhap = $('#txtInput').val();

        window.location.href = "/Information/SearchByName?name=" + giatrinhap;

    })
</script>
