<%@ Page Title="" Language="C#" MasterPageFile="~/_Easy/EasyMaster.Master" AutoEventWireup="true" CodeBehind="FrmContent1.aspx.cs" Inherits="MasterPage1._EasyPages.FrmContent1" %>
<%--<%@ MasterType virtualpath="~/_Easy/EasyMaster.Master" %>--%>
<%@ Register Assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" Namespace="System.Web.UI.DataVisualization.Charting" TagPrefix="asp" %>
<asp:content contentplaceholderid="head" runat="server">
</asp:content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

       <div class="col-lg-8 col-md-6 mb-md-0 mb-4" style="width:100%">
          <div class="card">
            <div class="card-header pb-0">
                <h3>Test Functionality</h3>
                <asp:Label ID="LblTestFun" runat="server" Text="Test Functionality"></asp:Label>
               <div class="input-group input-group-outline mb-3" style="width:30%;">
                     <asp:TextBox ID="TxtName" Class="form-control" runat="server">
                     </asp:TextBox>
               </div>
                 <div class="input-group input-group-outline mb-3" style="width:30%;">
                     <asp:TextBox ID="TxtPassword" Class="form-control" runat="server" TextMode="Password">
                     </asp:TextBox>
               </div>
                 <div class="input-group input-group-outline mb-3" style="width:30%;">
                     <asp:DropDownList ID="DdChoose"  Class="form-control" runat="server" OnLoad="Page_Load" >

                     </asp:DropDownList>
               </div>
                   <%--&nbsp; &nbsp; &nbsp;--%>
              <div>
              <asp:Button ID="BtnSubmit" Cssclass="btn bg-gradient-dark px-3 mb-2 active" runat="server" Text="Submit" OnClick="BtnSubmit_Click" />
              </div>
            </div>

                

          </div>
        </div>

    <br />
    <br />

     <div class="col-lg-8 col-md-6 mb-md-0 mb-4" style="width:100%">
          <div class="card">
            <div class="card-header pb-0">
                <h3>Data View</h3>

                <asp:GridView ID="DGVShow" runat="server" 
                    CssClass="table align-items-center mb-0" 
                    BorderStyle="None" AllowPaging="False" 
                    AllowSorting="True" AutoGenerateSelectButton="True" 
                    SelectedRowStyle-BorderStyle="Solid" 
                    SelectedRowStyle-BorderColor="#E32F6E" 
                    SelectedRowStyle-ForeColor="#E32F6E"
                    AutoGenerateColumns="False">

                  <Columns>
                       <asp:BoundField DataField="Id" HeaderText="المعرف" 
                       InsertVisible="False" ReadOnly="True" SortExpression="Id" ControlStyle-ForeColor="Blue" />
                       <asp:BoundField DataField="first_name" HeaderText="الإسم الأول" 
                       SortExpression="first_name" />
                       <asp:BoundField DataField="last_name" HeaderText="إسم العائلة" 
                       SortExpression="last_name" />
                 </Columns>

                </asp:GridView>

            </div>

          </div>
        </div>

   


</asp:Content>
