<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UserList.aspx.cs" Inherits="OobayashiSama.UserList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <script type="text/javascript">
        function alertBefore()
        {
            return confirm("本当に削除してよろしいですか？");
        }
    </script>

    <asp:GridView ID="UserGV" runat="server" AutoGenerateColumns="false" OnRowCommand="UserGV_RowCommand" OnRowDeleting="UserGV_RowDeleting" OnRowEditing="UserGV_RowEditing">
        <Columns>
            <asp:TemplateField HeaderText="番号">
                <ItemTemplate>
                    <asp:LinkButton ID="EditBtn" CommandName = "Edit" Text = '<%# Eval("番号") %>' runat="server" 
                        CommandArgument='<%# Eval("番号") %>' 
                        style="color:black;text-decoration:none;" />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField DataField="名前" HeaderText="名前" InsertVisible="False" ReadOnly="True" />
            <asp:TemplateField HeaderText="役職">
                <ItemTemplate>
                    <asp:TextBox ID="txtPosition" Text = '<%# Eval("役職") %>' runat="server"  />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField DataField="更新日" HeaderText="更新日" InsertVisible="False" ReadOnly="True" />
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:Button ID="DelBtn" CommandName = "Delete" Text = "削除" runat="server" 
                        CommandArgument='<%# Eval("番号") %>'  OnClientClick="return alertBefore();" />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
        <br />
        <asp:Button ID="btnImport" runat="server" OnClick="btnImport_Click" Text="取込" />
&nbsp; 名前絞込み<asp:TextBox ID="txtName" runat="server"></asp:TextBox>
        <asp:Button ID="btnSearch" runat="server" OnClick="btnSearch_Click" Text="検索" />
        <asp:Button ID="btnExport" runat="server" OnClick="btnExport_Click" Text="出力" />

</asp:Content>
