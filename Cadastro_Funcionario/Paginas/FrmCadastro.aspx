<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FrmCadastro.aspx.cs" Inherits="Cadastro_Funcionario.Paginas.FrmCadastro" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
        <div class="col-lg-12">
            <div class="form-panel">
              <h4 class="mb"><i class="fa fa-angle-right"></i>Cadastro de Funcionário</h4>
                <asp:Label ID="txtresp" runat="server" Font-Size="Large" ForeColor="Red" Text=""></asp:Label>
              <form class="form-horizontal style-form" method="get" runat="server">
                <div class="form-group">
                  <label class="col-sm-2 col-sm-2 control-label">Nome</label>
                  <div class="col-sm-10">
                      <asp:TextBox ID="txtnome" runat="server" class="form-control"></asp:TextBox>
                  </div>
                </div>
                <div class="form-group">
                  <label class="col-sm-2 col-sm-2 control-label">Sobrenome</label>
                  <div class="col-sm-10">
                      <asp:TextBox ID="txtsobrenome" runat="server" class="form-control"></asp:TextBox>
                  </div>
                </div>
                <div class="form-group">
                  <label class="col-sm-2 col-sm-2 control-label">E-mail</label>
                  <div class="col-sm-10">
                      <asp:TextBox ID="txtemail" runat="server" class="form-control" pattern="[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}$"></asp:TextBox>
                  </div>
                </div>
                <div class="form-group">
                  <label class="col-sm-2 col-sm-2 control-label">RG</label>
                  <div class="col-sm-10">
                      <asp:TextBox ID="txtrg" runat="server" class="form-control"></asp:TextBox>
                  </div>
                </div>
                <div class="form-group">
                  <label class="col-sm-2 col-sm-2 control-label">CPF</label>
                  <div class="col-sm-10">
                      <asp:TextBox ID="txtcpf" runat="server" class="form-control"></asp:TextBox>
                  </div>
                </div>
                <div class="form-group">
                  <label class="col-sm-2 col-sm-2 control-label">Endereço</label>
                  <div class="col-sm-10">
                      <asp:TextBox ID="txtendereco" runat="server" class="form-control"></asp:TextBox>
                  </div>
                </div>
                <div class="form-group">
                  <label class="col-sm-2 col-sm-2 control-label">Bairro</label>
                  <div class="col-sm-10">
                      <asp:TextBox ID="txtbairro" runat="server" class="form-control"></asp:TextBox>
                  </div>
                </div>
                <div class="form-group">
                  <label class="col-sm-2 col-sm-2 control-label">Cidade</label>
                  <div class="col-sm-10">
                      <asp:TextBox ID="txtcidade" runat="server" class="form-control"></asp:TextBox>
                  </div>
                </div>
                <div class="form-group">
                  <label class="col-sm-2 col-sm-2 control-label">UF</label>
                  <div class="col-sm-10">
                      <asp:TextBox ID="txtuf" runat="server" class="form-control" maxlength="2"></asp:TextBox>
                  </div>
                </div>
                <div class="form-group">
                  <label class="col-sm-2 col-sm-2 control-label">Departamento</label>
                  <div class="col-sm-10">
                      <asp:TextBox ID="txtdepartamento" runat="server" class="form-control"></asp:TextBox>
                  </div>
                </div>

                  <asp:Button ID="Cadastrar" runat="server" Text="Cadastrar" Class="btn btn-primary" OnClick="Cadastrar_Click" />

              </form>
            </div>
          </div>
</asp:Content>
