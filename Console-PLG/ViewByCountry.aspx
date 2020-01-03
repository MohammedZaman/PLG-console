<%@ Page Language="C#" Inherits="ConsolePLG.ViewByCountry" MasterPageFile="~/Master.master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contentPlaceHolder" runat="server">
<div  style="padding:50px 0px;">       
<div class="row">
  <div class="col s12 l4 offset-l4">
    <div class="card grey lighten-3">
      <div class="card-content">
        <h4 class="card-title center-align">View By Country</h4>
       
         <div class="row ">
            <div class="input-field col s12"> 
        
             <asp:DropDownList CssClass="dropdown-trigger btn" AutoPostBack="True" 
               onselectedindexchanged="getCompanies__SelectedIndexChanged"  ID="countriesDropDown" runat="server">
   
             </asp:DropDownList>
            
               <asp:RequiredFieldValidator InitialValue="-1"  Display="Dynamic" ID="RequiredFieldValidatorCompanies" runat="server" Style= "width: 128px; color:red;" ErrorMessage="RequiredFieldValidator"
                ControlToValidate="countriesDropDown">* Select a Country </asp:RequiredFieldValidator>
           </div>
           </div>
           
            <div class="row ">
            <div class="input-field col s12"> 
        
             <asp:DropDownList CssClass="dropdown-trigger btn"   ID="companiesDropDown" runat="server">
             </asp:DropDownList>
            
               
           </div>
           </div>
           
             <div class="row ">
            <div class="input-field col s12"> 
        
            
            <div class="row center-align">
          <asp:Button ID="filter" CssClass="btn waves-effect waves-light"  runat="server"  Text="Ascending" OnClick="filter_Click" />
          </div>
          </div>
               
           </div>
           
            <div class="row ">
               <p runat="server" id="comments">Comments:</p>
               
           </div>
           </div>
           
        
        
       
    </div>
  </div>
</div>
</div>

</asp:Content>