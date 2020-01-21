<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Employee.aspx.cs" Inherits="Mynew2.Employee" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
    Employee<br />
</p>
    <p>
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataSourceID="ObjectDataSource1" OnRowDeleting="GridView1_RowDeleting" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" ShowFooter="True" Width="877px">
            <Columns>
                <asp:TemplateField HeaderText="EmpName" SortExpression="EName">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("EName") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <FooterTemplate>
                        <asp:TextBox ID="txtename" runat="server"></asp:TextBox>
                    </FooterTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label2" runat="server" Text='<%# Bind("EName") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="EmpSal" SortExpression="ESal">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox3" runat="server" Text='<%# Bind("ESal") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <FooterTemplate>
                        <asp:TextBox ID="txtesalary" runat="server"></asp:TextBox>
                    </FooterTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label3" runat="server" Text='<%# Bind("ESal") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="DepatmentId" SortExpression="Dno">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox4" runat="server" Text='<%# Bind("Dno") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <FooterTemplate>
                        <asp:DropDownList ID="ddldep" runat="server" AutoPostBack="True" DataSourceID="SqlDataSourcedep" DataTextField="DName" DataValueField="Dno">
                        </asp:DropDownList>
                        <asp:SqlDataSource ID="SqlDataSourcedep" runat="server" ConnectionString="<%$ ConnectionStrings:Myconstr %>" SelectCommand="SELECT * FROM [Dept]"></asp:SqlDataSource>
                    </FooterTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label4" runat="server" Text='<%# Bind("Dno") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="StateId" SortExpression="StId">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox5" runat="server" Text='<%# Bind("StId") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <FooterTemplate>
                        <asp:DropDownList ID="ddlstate" runat="server" AutoPostBack="True" DataSourceID="SqlDataSourceState" DataTextField="StName" DataValueField="StId" OnSelectedIndexChanged="ddlstate_SelectedIndexChanged">
                        </asp:DropDownList>
                        <asp:SqlDataSource ID="SqlDataSourceState" runat="server" ConnectionString="<%$ ConnectionStrings:Myconstr %>" SelectCommand="SELECT * FROM [State]"></asp:SqlDataSource>
                    </FooterTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label5" runat="server" Text='<%# Bind("StId") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="CityId" SortExpression="CtId">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox6" runat="server" Text='<%# Bind("CtId") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <FooterTemplate>
                        <asp:DropDownList ID="ddlcity" runat="server" AutoPostBack="True" DataSourceID="ObjectDataSourcecity" DataTextField="CtName" DataValueField="CtId">
                        </asp:DropDownList>
                        <asp:ObjectDataSource ID="ObjectDataSourcecity" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetCityByStID" TypeName="Mynew2.DBManagerState">
                            <SelectParameters>
                                <asp:SessionParameter Name="StId" SessionField="StId" Type="Int32" />
                            </SelectParameters>
                        </asp:ObjectDataSource>
                    </FooterTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label6" runat="server" Text='<%# Bind("CtId") %>'></asp:Label>
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
                <asp:TemplateField HeaderText="EmpCode" SortExpression="ECode">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("ECode") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <FooterTemplate>
                        <asp:TextBox ID="txtempcode" runat="server"></asp:TextBox>
                    </FooterTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%# Bind("ECode") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
            <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
            <RowStyle BackColor="White" ForeColor="#330099" />
            <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
            <SortedAscendingCellStyle BackColor="#FEFCEB" />
            <SortedAscendingHeaderStyle BackColor="#AF0101" />
            <SortedDescendingCellStyle BackColor="#F6F0C0" />
            <SortedDescendingHeaderStyle BackColor="#7E0000" />
        </asp:GridView>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" DeleteMethod="DeleteEmp" InsertMethod="SaveEmp" OldValuesParameterFormatString="original_{0}" SelectMethod="GetAllEmp" TypeName="Mynew2.DBManagerEmp" UpdateMethod="UpdateEmp">
            <DeleteParameters>
                <asp:Parameter Name="ECode" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="ECode" Type="Int32" />
                <asp:Parameter Name="EName" Type="String" />
                <asp:Parameter Name="ESal" Type="Int32" />
                <asp:Parameter Name="Dno" Type="Int32" />
                <asp:Parameter Name="StId" Type="Int32" />
                <asp:Parameter Name="CtId" Type="Int32" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="ECode" Type="Int32" />
                <asp:Parameter Name="EName" Type="String" />
                <asp:Parameter Name="ESal" Type="Int32" />
                <asp:Parameter Name="Dno" Type="Int32" />
                <asp:Parameter Name="StId" Type="Int32" />
                <asp:Parameter Name="CtId" Type="Int32" />
            </UpdateParameters>
        </asp:ObjectDataSource>
</p>
    <p>
        &nbsp;</p>
<p>
</p>
</asp:Content>
