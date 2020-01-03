<%@ Page Language="C#" Inherits="ConsolePLG.AddCompany" MasterPageFile="~/Master.master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contentPlaceHolder" runat="server">
<div  style="padding:50px 0px;">       
<div class="row">
  <div class="col s12 l4 offset-l4">
    <div class="card grey lighten-3">
      <div class="card-content">
        <h4 class="card-title center-align">Add a Company</h4>
       
          <div class="row">
            <div class="input-field col s12">
              <i class="material-icons prefix">business_center</i>
              <asp:TextBox CssClass="validate" ID="compTxtBox" runat="server"></asp:TextBox>
               <asp:RequiredFieldValidator ID="RequiredFieldValidatorPassword" runat="server" Style= "width: 128px; color:red;" ErrorMessage="RequiredFieldValidator"
                ControlToValidate="compTxtBox">* Fill in required Field </asp:RequiredFieldValidator>
              <label for="CompTextbox">Company Name</label>
            </div>
          </div>
          
           <div class="row" style="overflow-y: scroll; height:200px; font-color:black; font-size:14px;background-color:white; ">
            <div class="input-field col s12">
            <p>Select countries to restrict</p>

         <asp:CheckBoxList ID="CountriesCBList"  CssClass="filled-in reset-checkbox" runat="server">
                      
        </asp:CheckBoxList>
        
        </div>
       </div>
       
         <div class="row">
            <div class="input-field col s12">
              <i class="material-icons prefix">message</i>
              <asp:TextBox CssClass="validate" ID="commentTxtBox" runat="server"></asp:TextBox>
              <label for="commentTxtBox">Comments(Optional)</label>
            </div>
          </div>
          
         <div class="row center-align">
          <asp:Button ID="submit" CssClass="btn waves-effect waves-light"  runat="server" Text="Add" OnClick="Add_Click"  />
          </div>
       
    </div>
  </div>
</div>
</div>
</div>



</asp:Content>
