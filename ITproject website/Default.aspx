


<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">



    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.5.0/jquery.min.js" type="text/javascript"><!--mce:0--></script>
  <script type="text/javascript">
      $(document).ready(function () {
          // Set the interval to be 5 seconds
          var t = setInterval(function () {
              $("#carousel ul").animate({ marginLeft: 0 }, 8000, function () {
                  $(this).find("li:last").after($(this).find("li:first"));
                  $(this).css({ marginLeft: 0 });
              })
          }, 5000);
      });
  </script>


    <div id = "page">
            <div class ="page_title">
                <h1>Welcome to Mid Lin</h1>
            </div>
            <div class ="page_content">
                <asp:Panel ID="Panel1" runat="server">
                    <div id="carousel">
                        <ul>
                            <li><img src="images/header_01.jpg" alt="Fish" width="100%" /></li>
                            <li><img src="images/header_02.jpg" alt="Elephant" width="100%" /></li>
                            <li><img src="images/header_03.jpg" alt="Giraffe" width="100%" /></li>
                        </ul>
                        </div>
                    <div id ="carousel_text">
                        <p>Mid - Lin Day Care Centre for older people is run by staff and volunteers Monday to Friday 
9.00 am - 5.00 pm. Providing activities, friendship, care and good food.</p>
                    </div>
                </asp:Panel>
            </div>
            <div class ="page_footer">
                <p>
We will endeavour to make sure that all service users reach their full potential through consultation and choice.
No one will be discriminated against because of race, religion or disability.
We will provide a safe and happy place to be.<br />
                    </p>
            </div>
        </div>
 
</asp:Content>

