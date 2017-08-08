<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UserEdit.aspx.cs" Inherits="OobayashiSama.UserEdit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <script type="text/javascript">
        function alertBeforeUpd()
        {
            return confirm("更新後、一覧に戻ります。更新しますか？");
        }
    </script>

    番号：<asp:Label ID="lblNo" runat="server" />
    <br />
    名前：<asp:TextBox ID="txtName" runat="server" Width="100" />
    <br />
    役職：<asp:TextBox ID="txtPosition" runat="server" Width="100" />
    <br />
    <asp:Button ID="btnEdit" runat="server" Text="更新" OnClick="btnEdit_Click" OnClientClick="return alertBeforeUpd();" />
    <asp:Button ID="btnBack" runat="server" Text="一覧へ戻る" OnClick="btnBack_Click" />
    <br />
    <asp:Label ID="lblValid" runat="server" ForeColor="Red" Font-Bold="true" />
</asp:Content>
