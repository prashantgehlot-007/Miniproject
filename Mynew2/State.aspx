<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="State.aspx.cs" Inherits="Mynew2.State" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        State</p>
    <p>
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False" CellPadding="4" DataSourceID="ObjectDataSource1" ForeColor="#333333" GridLines="None" OnRowDeleting="GridView1_RowDeleting" ShowFooter="True">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:TemplateField HeaderText="StateId" SortExpression="StId">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("StId") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <FooterTemplate>
                        <asp:TextBox ID="txtstateid" runat="server"></asp:TextBox>
                    </FooterTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%# Bind("StId") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="StateName" SortExpression="StName">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("StName") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <FooterTemplate>
                        <asp:TextBox ID="txtstatename" runat="server"></asp:TextBox>
                    </FooterTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label2" runat="server" Text='<%# Bind("StName") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Action">
                    <EditItemTemplate>
                        <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="True" CommandName="Update" Text="Update"></asp:LinkButton>
                        &nbsp;<asp:LinkButton ID="LinkButton2" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel"></asp:LinkButton>
                    </EditItemTemplate>
                    <FooterTemplate>
                        <asp:LinkButton ID="LinkButton4" runat="server" OnClick="LinkButton4_Click">Insert</asp:LinkButton>
                    </FooterTemplate>
                    <ItemTemplate>
                        <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" CommandName="Edit" Text="Edit"></asp:LinkButton>
                        &nbsp;<asp:LinkButton ID="LinkButton2" runat="server" CausesValidation="False" CommandName="Select" Text="Select"></asp:LinkButton>
                        &nbsp;<asp:LinkButton ID="LinkButton3" runat="server" CausesValidation="False" CommandName="Delete" Text="Delete"></asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" DeleteMethod="DeleteState" InsertMethod="SaveState" OldValuesParameterFormatString="original_{0}" SelectMethod="GetAllState" TypeName="Mynew2.DBManagerState" UpdateMethod="UpdateState">
            <DeleteParameters>
                <asp:Parameter Name="StId" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="StId" Type="Int32" />
                <asp:Parameter Name="StName" Type="String" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="StId" Type="Int32" />
                <asp:Parameter Name="StName" Type="String" />
            </UpdateParameters>
        </asp:ObjectDataSource>
        <br />
    </p>
    <p>
    </p>
</asp:Content>
