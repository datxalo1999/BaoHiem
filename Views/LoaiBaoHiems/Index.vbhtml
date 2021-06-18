@ModelType IEnumerable(Of WebBaoHiem.LoaiBaoHiem)
@Code
ViewData("Title") = "Index"
Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>THÔNG TIN LOẠI BẢO HIỂM</h2>

<p>
    @Html.ActionLink("Thêm mới", "Create")
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.LoaiBaoHiem1)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.LoaiBaoHiem1)
        </td>
        <td>
            @Html.ActionLink("Sửa", "Edit", New With {.id = item.id}) |
            @Html.ActionLink("Chi tiết", "Details", New With {.id = item.id}) |
            @Html.ActionLink("Xoá", "Delete", New With {.id = item.id})
        </td>
    </tr>
Next

</table>
