


<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
 <!-- 
     <div class ="post">
     <div class ="post_title">

     </div>
     <div class ="post_image">

     </div>
     <div class ="post_content">

     </div>
     <div class ="post_author">

     </div>
</div> 
     -->
<div class="content_holder">

    <div id ="page_title">
                <h2>Welcome to Mid Lin</h2>
            </div>
            <div id ="page_content">
                <asp:Panel ID="pagePanel" runat="server">
                    <div id ="front_image">
                                <!--<img src="images/header_03.jpg" width ="100%" /> -->

                        <!--Javascript-->
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

                        <div id="carousel">
                        <ul>
                            <li><img src="images/header_01.jpg" alt="Fish" width="100%" /></li>
                            <li><img src="images/header_02.jpg" alt="Elephant" width="100%" /></li>
                            <li><img src="images/header_03.jpg" alt="Giraffe" width="100%" /></li>
                        </ul>
                        </div>
                        








                    </div>
                    <div id ="front_image_text">
                        <p>Mid - Lin Day Care Centre for older people is run by staff and volunteers Monday to Friday 
9.00 am - 5.00 pm. Providing activities, friendship, care and good food.</p>
                    </div>
                </asp:Panel>
            </div>
            <div id ="page_author">
                <div id ="other">
                    <i><p>
We will endeavour to make sure that all service users reach their full potential through consultation and choice.
No one will be discriminated against because of race, religion or disability.
We will provide a safe and happy place to be.<br />
                    </p></i>
                </div>
                <div id ="postcode">
                    <i><p>
                        59 Pitkerro Drive<br />
                        Linlathen<br />
                        Dundee DD4 8AT<br />
                        01382 506451<br />
                        officemidlin@yahoo.co.uk
                    </p></i>
                </div>
                
            </div>


</div>
</asp:Content>

