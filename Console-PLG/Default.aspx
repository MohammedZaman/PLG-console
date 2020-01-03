﻿<%@ Page Language="C#" Inherits="ConsolePLG.Default" MasterPageFile="~/Master.master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contentPlaceHolder" runat="server">

<div  style="padding:50px 0px;">       
<div class="row">
  <div class="col s12 l4 offset-l4">
    <div class="card grey lighten-3">
      <div class="card-content">
        <h4 class="card-title center-align">Login</h4>
        
          <div class="row">
            <div class="input-field col s12">              
            <i class="material-icons prefix">account_box</i>
              <asp:TextBox CssClass="validate" ID="uTxtBox" runat="server"></asp:TextBox>
               <asp:RequiredFieldValidator ID="RequiredFieldValidatorEmail" runat="server" Style= "width: 128px; color:red;" ErrorMessage="RequiredFieldValidator"
                ControlToValidate="uTxtBox">* Fill in required Field </asp:RequiredFieldValidator>
              <label for="uTxtBox">Username</label>
            </div>
          </div>
          <div class="row">
            <div class="input-field col s12">
              <i class="material-icons prefix">vpn_key</i>
              <asp:TextBox CssClass="validate" ID="passwordTxtBox" TextMode="Password" runat="server"></asp:TextBox>
               <asp:RequiredFieldValidator ID="RequiredFieldValidatorPassword" runat="server" Style= "width: 128px; color:red;" ErrorMessage="RequiredFieldValidator"
                ControlToValidate="passwordTxtBox">* Fill in required Field </asp:RequiredFieldValidator>
              <label for="passwordTxtBox">Password</label>
            </div>
          </div>
          <div class="row center-align">
          <asp:Button ID="submit" CssClass="btn waves-effect waves-light"  runat="server" Text="Submit" OnClick="submit_Click"  />
          </div>

      </div>
    </div>
  </div>
</div>
</div>
</asp:Content>