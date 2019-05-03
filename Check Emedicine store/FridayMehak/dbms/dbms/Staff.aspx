<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Staff.aspx.cs" Inherits="dbms.Staff" %>


                
 
<!DOCTYPE html>
<html>
<head>
  <meta charset="utf-8">
  <meta http-equiv="X-UA-Compatible" content="IE=edge">
  <title>AdminLTE 2 | Dashboard</title>
  <!-- Tell the browser to be responsive to screen width -->
  <meta content="width=device-width, initial-scale=1, maximum-scale=1, user-scalable=no" name="viewport">
  <!-- Bootstrap 3.3.7 -->
  <link rel="stylesheet" href="fonts/bower_components/bootstrap/dist/css/bootstrap.min.css">


    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/jquery-1.10.2.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>


  <!-- Font Awesome -->
  <link rel="stylesheet" href="fonts/bower_components/font-awesome/css/font-awesome.min.css">
  <!-- Ionicons -->
  <link rel="stylesheet" href="fonts/bower_components/Ionicons/css/ionicons.min.css">
  <!-- Theme style -->
  <link rel="stylesheet" href="fonts/dist/css/AdminLTE.min.css">
  <!-- AdminLTE Skins. Choose a skin from the css/skins
       folder instead of downloading all of them to reduce the load. -->
  <link rel="stylesheet" href="fonts/dist/css/skins/_all-skins.min.css">
  <!-- Morris chart -->
  <link rel="stylesheet" href="fonts/bower_components/morris.js/morris.css">
  <!-- jvectormap -->
  <link rel="stylesheet" href="fonts/bower_components/jvectormap/jquery-jvectormap.css">
  <!-- Date Picker -->
  <link rel="stylesheet" href="fonts/bower_components/bootstrap-datepicker/dist/css/bootstrap-datepicker.min.css">
  <!-- Daterange picker -->
  <link rel="stylesheet" href="fonts/bower_components/bootstrap-daterangepicker/daterangepicker.css">
  <!-- bootstrap wysihtml5 - text editor -->
  <link rel="stylesheet" href="fonts/plugins/bootstrap-wysihtml5/bootstrap3-wysihtml5.min.css">

  <!-- HTML5 Shim and Respond.js IE8 support of HTML5 elements and media queries -->
  <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
  <!--[if lt IE 9]>
  <script src="https://oss.maxcdn.com/html5shiv/3.7.3/html5shiv.min.js"></script>
  <script src="https://oss.maxcdn.com/respond/1.4.2/respond.min.js"></script>
  <![endif]-->

  <!-- Google Font -->
  <link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Source+Sans+Pro:300,400,600,700,300italic,400italic,600italic">
</head>
<body class="hold-transition skin-blue sidebar-mini">
<div class="wrapper">

  <header class="main-header">
    <!-- Logo -->
    <a href="index2.html" class="logo">
      <!-- mini logo for sidebar mini 50x50 pixels -->
      <span class="logo-mini"><b>A</b></span>
      <!-- logo for regular state and mobile devices -->
      <span class="logo-lg"><b>Admin</b></span>
    </a>
    <!-- Header Navbar: style can be found in header.less -->
    <nav class="navbar navbar-static-top">
      <!-- Sidebar toggle button-->
      

      <div class="navbar-custom-menu">
        <ul class="nav navbar-nav">
          <!-- Messages: style can be found in dropdown.less-->
          <li class="dropdown messages-menu">
           
            <ul class="dropdown-menu">
             
              <li>
                <!-- inner menu: contains the actual data -->
                <ul class="menu">
                
                
                </ul>
              </li>
             
            </ul>
          </li>
          <!-- Notifications: style can be found in dropdown.less -->
          <li class="dropdown notifications-menu">
            <a href="#" class="dropdown-toggle" data-toggle="dropdown">
             
            
            </a>
            <ul class="dropdown-menu">
             
              <li>
                <!-- inner menu: contains the actual data -->
                <ul class="menu">
                 
                
                 
                </ul>
              </li>
              <li class="footer"></li>
            </ul>
          </li>
          <!-- Tasks: style can be found in dropdown.less -->
          <li class="dropdown tasks-menu">
            <a href="#" class="dropdown-toggle" data-toggle="dropdown">
             
             
            </a>
            <ul class="dropdown-menu">
             
              <li>
                <!-- inner menu: contains the actual data -->
                <ul class="menu">
                  <li><!-- Task item -->
                    <a href="#">
                     
                      <div class="progress xs">
                        <div class="progress-bar progress-bar-aqua" style="width: 20%" role="progressbar"
                             aria-valuenow="20" aria-valuemin="0" aria-valuemax="100">
                         
                        </div>
                      </div>
                    </a>
                  </li>
                  <!-- end task item -->
                  <li><!-- Task item -->
                    <a href="#">
                     
                      <div class="progress xs">
                        <div class="progress-bar progress-bar-green" style="width: 40%" role="progressbar"
                             aria-valuenow="20" aria-valuemin="0" aria-valuemax="100">
                        
                        </div>
                      </div>
                    </a>
                  </li>
                  <!-- end task item -->
                  <li><!-- Task item -->
                    <a href="#">
                     
                      <div class="progress xs">
                        <div class="progress-bar progress-bar-red" style="width: 60%" role="progressbar"
                             aria-valuenow="20" aria-valuemin="0" aria-valuemax="100">

                        </div>
                      </div>
                    </a>
                  </li>
                  <!-- end task item -->
                  <li><!-- Task item -->
                    <a href="#">
                     
                      <div class="progress xs">
                        <div class="progress-bar progress-bar-yellow" style="width: 80%" role="progressbar"
                             aria-valuenow="20" aria-valuemin="0" aria-valuemax="100">
                         
                        </div>
                      </div>
                    </a>
                  </li>
                  <!-- end task item -->
                </ul>
              </li>
              <li class="footer">
               
              </li>
            </ul>
          </li>
          <!-- User Account: style can be found in dropdown.less -->
          <li class="dropdown user user-menu">
            <a href="#" class="dropdown-toggle" data-toggle="dropdown">
           
            </a>
            <ul class="dropdown-menu">
              <!-- User image -->
              <li class="user-header">
                
              </li>
              <!-- Menu Body -->
              <li class="user-body">
                <div class="row">
                  <div class="col-xs-4 text-center">
                  
                  </div>
                  <div class="col-xs-4 text-center">
                   
                  </div>
                  <div class="col-xs-4 text-center">
                   
                  </div>
                </div>
                <!-- /.row -->
              </li>
              <!-- Menu Footer-->
              <li class="user-footer">
                <div class="pull-left">
                  
                </div>
                <div class="pull-right">
                 
                </div>
              </li>
            </ul>
          </li>
          <!-- Control Sidebar Toggle Button -->
                <li><a runat="server" href="Main.aspx">Home</a></li>
                <li><a runat="server" href="Main.aspx">Sign Out</a></li>
        </ul>
      </div>
    </nav>
  </header>
  <!-- Left side column. contains the logo and sidebar -->
  <aside class="main-sidebar">
    <!-- sidebar: style can be found in sidebar.less -->
    <section class="sidebar">
      <!-- Sidebar user panel -->
      <div class="user-panel">
        <div class="pull-left image">
         
        </div>
        <div class="pull-left info">
         
        </div>
      </div>
      <!-- search form -->
      <form action="#" method="get" class="sidebar-form">
        <div class="input-group">
         
          <span class="input-group-btn">
                
              </span>
        </div>
      </form>
      <!-- /.search form -->
      <!-- sidebar menu: : style can be found in sidebar.less -->
      


          <ul class="sidebar-menu" data-widget="tree">
       
          <li>
          <a href="Staff.aspx">
            <i class="fa fa-book"></i> <span>Satff</span>
           
          </a>
        </li>
        <li>
          <a href="Attendance.aspx">
            <i class="fa fa-calendar"></i> <span>Attendance</span>
            
          </a>
        </li>
    






           <li>
          <a href="Adminpage.aspx">
            <i class="fa-industry"></i> <span>Pharmacy</span>
            
          </a>
        </li>

        <li class="active treeview">
          <a href="#">
            <i class="fa fa-dashboard"></i> <span>Reports</span>
            <span class="pull-right-container">
             
            </span>
          </a>
          <ul class="treeview-menu">
            <li><a href="index.html"><i class="fa fa-circle-o"></i> Attendance Detail</a></li>
            <li><a href="index2.html"><i class="fa fa-circle-o"></i>Staff Detail</a></li>
          </ul>
        </li>
        <li class="treeview">
        
         
        </li>
       
        <li class="treeview">
         
         
        </li>
        <li class="treeview">
          
          
        </li>
        <li class="treeview">
         
        </li>
        <li class="treeview">
          
        </li>
       
       
        <li class="treeview">
         
          <ul class="treeview-menu">
          
          </ul>
        </li>
        <li class="treeview">
         
          <ul class="treeview-menu">
            
            <li class="treeview">
           
                <span class="pull-right-container">
                
                </span>
              </a>
              <ul class="treeview-menu">
               
                <li class="treeview">
                
                  <ul class="treeview-menu">
                   
                  </ul>
                </li>
              </ul>
            </li>
           
          </ul>
        </li>
   
      </ul>
       
           
       

          

       
         
           
            
    </section>
    <!-- /.sidebar -->
  </aside>

  <!-- Content Wrapper. Contains page content -->
  <div class="content-wrapper">

      <section class="content-header">
      <h1>
        <b>Staff</b>
        
      </h1>
      
         <form id="frm" runat="server">
        <asp:Label ID="lblName" runat="server" Text="Staff Member Name" Font-Bold="true"></asp:Label>
             
             
             
             <br />
        <asp:TextBox ID="txtName" runat="server" Width="400px"></asp:TextBox>
             <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Field is empty" ControlToValidate="txtName" ForeColor="#FF3300"></asp:RequiredFieldValidator>
             <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtName" ErrorMessage="wrong format" ForeColor="#0066CC" ValidationExpression="[a-zA-Z]+"></asp:RegularExpressionValidator>
             &nbsp;&nbsp;&nbsp; <br /><br />


       <asp:Label ID="lblEmail" runat="server" Text="Email"  Font-Bold="true"></asp:Label>
             
             <br />
      <asp:TextBox ID="txtEmail" runat="server" Width="400px"></asp:TextBox>
       <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Field is empty" ControlToValidate="txtName" ForeColor="#FF3300"></asp:RequiredFieldValidator>      
             <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txtEmail" ErrorMessage="wrong format" ForeColor="#0066CC" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator><br /><br />




       <asp:Label ID="lblPassword" runat="server" Text="Password" Font-Bold="true"></asp:Label><br />
          <asp:TextBox ID="txtPassword" runat="server" Width="400px"></asp:TextBox>
             <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Field is empty" ControlToValidate="txtPassword" ForeColor="#FF3300"></asp:RequiredFieldValidator><br /><br />

              <asp:Label ID="lblConfirmPwd" runat="server" Text="Confirm password" Font-Bold="true"></asp:Label><br />
          <asp:TextBox ID="txtConfirmPwd" runat="server" Width="400px"></asp:TextBox>
             <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Field is empty" ControlToValidate="txtConfirmPwd" ForeColor="#FF3300"></asp:RequiredFieldValidator>
             <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtPassword" ControlToValidate="txtConfirmPwd" ErrorMessage="password not match" ForeColor="#0066CC"></asp:CompareValidator>
             <br /><br />

              <asp:Label ID="lblAddress" runat="server" Text="Address" Font-Bold="true"></asp:Label><br />
          <asp:TextBox ID="txtAddress" runat="server" Width="400px"></asp:TextBox>
             <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Field is empty" ControlToValidate="txtAddress" ForeColor="#FF3300"></asp:RequiredFieldValidator><br /><br />

              <asp:Label ID="lblPhoneno" runat="server" Text="Phone #" Font-Bold="true"></asp:Label><br />
          <asp:TextBox ID="txtPhoneno" runat="server" Width="400px"></asp:TextBox>
             <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="Field is empty" ControlToValidate="txtPhoneno" ForeColor="#FF3300"></asp:RequiredFieldValidator><asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="txtPhoneno" ErrorMessage="wrong format" ForeColor="#0066CC" ValidationExpression="[0-9]{10}"></asp:RegularExpressionValidator>
             &nbsp;<br /><br />


              <asp:Label ID="lblGender" runat="server" Text="Gender" Font-Bold="true"></asp:Label><br />
          <asp:TextBox ID="txtGender" runat="server" Width="400px"></asp:TextBox>
             <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ErrorMessage="Field is empty" ControlToValidate="txtGender" ForeColor="#FF3300"></asp:RequiredFieldValidator><br /><br />


              <asp:Label ID="lblPharmacy" runat="server" Text="Pharmacy" Font-Bold="true"></asp:Label><br />
          <asp:TextBox ID="txtPharmacy" runat="server" Width="400px"></asp:TextBox>
             <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ErrorMessage="Field is empty" ControlToValidate="txtPharmacy" ForeColor="#FF3300"></asp:RequiredFieldValidator><br /><br />

             <asp:Label ID="lblSalary" runat="server" Text="Salary" Font-Bold="true"></asp:Label>
             
             <br />
          <asp:TextBox ID="txtSalary" runat="server" Width="400px">

          </asp:TextBox>
             <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" ControlToValidate="txtSalary" ErrorMessage="wrong format" ForeColor="#0066CC" ValidationExpression="(^([0-9]*|\d*\d{1}?\d*)$)"></asp:RegularExpressionValidator>
             &nbsp;<br /><br />

              
            


            

                    

            







         <asp:Button ID="cmdSaveRecord" runat="server" Text="Save Record" BorderStyle="Groove" BackColor="RoyalBlue" Height="35px" OnClick="Button1_Click"  />
       <br /><br />
         <asp:Label ID="lblSaveRecord" runat="server" Text="" ForeColor="Blue" ></asp:Label>
            

            


               <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" CellPadding="15" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating" OnRowDeleting="GridView1_RowDeleting">  
              <Columns>
                  <asp:TemplateField>
                      <ItemTemplate>
                          <asp:Button ID="btn_Edit" runat="server" Text="Edit" CommandName="Edit" />

                      </ItemTemplate>
                      <EditItemTemplate>
                          <asp:Button ID="btn_Update" runat="server" Text="Update" CommandName="Update" />
                          <asp:Button ID="btn_Cancel" runat="server" Text="Cancel" CommandName="Cancel" />
                      </EditItemTemplate>
                  </asp:TemplateField>

                  <asp:TemplateField HeaderText="Actions">
                      <ItemTemplate>
                          <asp:Button ID="Delete" runat="server" Text="Delete" CommandName="Delete" />
                      </ItemTemplate>
                  </asp:TemplateField>


                  <asp:TemplateField HeaderText="ID">
                      <ItemTemplate>
                          
                          <asp:Label ID="lbl_ID" runat="server" Text='<%#Eval("StaffID") %>'></asp:Label>

                      </ItemTemplate>
                  </asp:TemplateField>

                   <asp:TemplateField HeaderText="Staff Member Name">  
                    <ItemTemplate>  
                        <asp:Label ID="lbl_name" runat="server" Text='<%#Eval("Name") %>'></asp:Label>
                    </ItemTemplate>  
                    <EditItemTemplate>  
                        <asp:TextBox ID="txt_Name" runat="server" Text='<%#Eval("Name") %>'></asp:TextBox> 
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="txt_Name" ErrorMessage="Field is empty" ForeColor="#FF3300"></asp:RequiredFieldValidator> 
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator5" runat="server" ControlToValidate="txt_Name" ErrorMessage="wrong format" ForeColor="#0066CC" ValidationExpression="[a-zA-Z]+"></asp:RegularExpressionValidator>
                         
                    
                    
                    
          
                    
                    </EditItemTemplate>  
                </asp:TemplateField>  

                      <asp:TemplateField HeaderText="Email">  
                    <ItemTemplate>  
                        <asp:Label ID="lbl_Email" runat="server" Text='<%#Eval("Email") %>'></asp:Label>
                    </ItemTemplate>  
                    <EditItemTemplate>  
                        <asp:TextBox ID="txt_Email" runat="server" Text='<%#Eval("Email") %>'></asp:TextBox>  
                         <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ControlToValidate="txt_Email" ErrorMessage="Field is empty" ForeColor="#FF3300"></asp:RequiredFieldValidator> 
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator6" runat="server" ControlToValidate="txt_Email" ErrorMessage="wrong format" ForeColor="#0066CC" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                    </EditItemTemplate>  
                </asp:TemplateField>  

                 


                      <asp:TemplateField HeaderText="Password">  
                    <ItemTemplate>  
                        <asp:Label ID="lbl_Password" runat="server" Text='<%#Eval("Password") %>'></asp:Label>
                    </ItemTemplate>  
                    <EditItemTemplate>  
                        <asp:TextBox ID="txt_Password" runat="server" Text='<%#Eval("Password") %>'></asp:TextBox> 
                         
                       <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" ControlToValidate="txt_Password" ErrorMessage="Field is empty" ForeColor="#FF3300"></asp:RequiredFieldValidator>  
                    
                    </EditItemTemplate>  
                </asp:TemplateField>  

                   <asp:TemplateField HeaderText="Confirm_Password">  
                    <ItemTemplate>  
                        <asp:Label ID="lbl_Confirm_Password" runat="server" Text='<%#Eval("Confirm_Password") %>'></asp:Label>
                    </ItemTemplate>  
                    <EditItemTemplate>  
                        <asp:TextBox ID="txt_Confirm_Password" runat="server" Text='<%#Eval("Confirm_Password") %>'></asp:TextBox>  
                         <asp:RequiredFieldValidator ID="RequiredFieldValidator12" runat="server" ControlToValidate="txt_Confirm_Password" ErrorMessage="Field is empty" ForeColor="#FF3300"></asp:RequiredFieldValidator> 
                        <asp:CompareValidator ID="CompareValidator3" runat="server" ControlToCompare="txt_Password" ControlToValidate="txt_Confirm_Password" ErrorMessage="password not match" ForeColor="#0066CC"></asp:CompareValidator>

                    </EditItemTemplate>  
                </asp:TemplateField>  

                   <asp:TemplateField HeaderText="Address">  
                    <ItemTemplate>  
                        <asp:Label ID="lbl_Address" runat="server" Text='<%#Eval("Address") %>'></asp:Label>
                    </ItemTemplate>  
                    <EditItemTemplate>  
                        <asp:TextBox ID="txt_Address" runat="server" Text='<%#Eval("Address") %>'></asp:TextBox> 
                         <asp:RequiredFieldValidator ID="RequiredFieldValidator13" runat="server" ControlToValidate="txt_Address" ErrorMessage="Field is empty" ForeColor="#FF3300"></asp:RequiredFieldValidator> 
                         
                    </EditItemTemplate>  
                </asp:TemplateField>  

                   <asp:TemplateField HeaderText="Phone #">  
                    <ItemTemplate>  
                        <asp:Label ID="lbl_Phoneno" runat="server" Text='<%#Eval("Phoneno") %>'></asp:Label>
                    </ItemTemplate>  
                    <EditItemTemplate>  
                        <asp:TextBox ID="txt_Phoneno" runat="server" Text='<%#Eval("Phoneno") %>'></asp:TextBox>  
                         <asp:RequiredFieldValidator ID="RequiredFieldValidator14" runat="server" ControlToValidate="txt_Phoneno" ErrorMessage="Field is empty" ForeColor="#FF3300"></asp:RequiredFieldValidator> 
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator7" runat="server" ControlToValidate="txt_Phoneno"       ErrorMessage="wrong format" ForeColor="#0066CC" ValidationExpression="[0-9]{10}"></asp:RegularExpressionValidator>

                   
                    </EditItemTemplate>  
                </asp:TemplateField>  

                  <asp:TemplateField HeaderText="Gender">  
                    <ItemTemplate>  
                        <asp:Label ID="lbl_Gender" runat="server" Text='<%#Eval("Gender") %>'></asp:Label>
                    </ItemTemplate>  
                    <EditItemTemplate>  
                        <asp:TextBox ID="txt_Gender" runat="server" Text='<%#Eval("Gender") %>'></asp:TextBox>  
                         
                    </EditItemTemplate>  
                </asp:TemplateField>  

                   <asp:TemplateField HeaderText="Pharmacy">  
                    <ItemTemplate>  
                        <asp:Label ID="lbl_PharmacyID" runat="server" Text='<%#Eval("PharmacyID") %>'></asp:Label>
                    </ItemTemplate>  
                    <EditItemTemplate>  
                        <asp:TextBox ID="txt_PharmacyID" runat="server" Text='<%#Eval("PharmacyID") %>'></asp:TextBox>  
                    </EditItemTemplate>  
                </asp:TemplateField>  

                   <asp:TemplateField HeaderText="Salary">  
                    <ItemTemplate>  
                        <asp:Label ID="lbl_Salary" runat="server" Text='<%#Eval("Salary") %>'></asp:Label>
                    </ItemTemplate>  
                    <EditItemTemplate>  
                        <asp:TextBox ID="txt_Salary" runat="server" Text='<%#Eval("Salary") %>'></asp:TextBox>  
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator15" runat="server" ControlToValidate="txt_Salary" ErrorMessage="Field is empty" ForeColor="#FF3300"></asp:RequiredFieldValidator> 
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator8" runat="server" ControlToValidate="txt_Salary"  ErrorMessage="wrong format" ForeColor="#0066CC" ValidationExpression="(^([0-9]*|\d*\d{1}?\d*)$)"></asp:RegularExpressionValidator>
                    </EditItemTemplate>  
                </asp:TemplateField>  

                   
                   
                       
              </Columns>
             </asp:GridView><br /><br />


            
         </form>
                    
    </section>
    <!-- Content Header (Page header) -->
    <section class="content-header">
                    
        
                    
    </section>
                 

    <!-- Main content -->
    <section class="content">
      <!-- Small boxes (Stat box) -->
      <div class="row">
        
        <!-- ./col -->
        <div class="col-lg-3 col-xs-6">
          <!-- small box -->
         
        </div>
        <!-- ./col -->
        <div class="col-lg-3 col-xs-6">
          <!-- small box -->
          
        </div>
        <!-- ./col -->
        <div class="col-lg-3 col-xs-6">
          <!-- small box -->
        
        </div>
        <!-- ./col -->
      </div>
      <!-- /.row -->
      <!-- Main row -->
      <div class="row">
        <!-- Left col -->
        <section class="col-lg-7 connectedSortable">
          <!-- Custom tabs (Charts with tabs)-->
         
          <!-- /.nav-tabs-custom -->

        
       
          <!-- /.box -->

          <!-- quick email widget -->
          

        </section>
        <!-- /.Left col -->
        <!-- right col (We are only adding the ID to make the widgets sortable)-->
        <section class="col-lg-5 connectedSortable">

        
          <!-- /.box -->

          <!-- Calendar -->
       
          <!-- /.box -->

        </section>
        <!-- right col -->
      </div>
      <!-- /.row (main row) -->

    </section>
    <!-- /.content -->
  </div>
  <!-- /.content-wrapper -->
  <footer class="main-footer">
    <div class="pull-right hidden-xs">
     
    </div>
    
  </footer>

  <!-- Control Sidebar -->
  <aside class="control-sidebar control-sidebar-dark">
    <!-- Create the tabs -->
    <ul class="nav nav-tabs nav-justified control-sidebar-tabs">
      <li><a href="#control-sidebar-home-tab" data-toggle="tab"><i class="fa fa-home"></i></a></li>
      <li><a href="#control-sidebar-settings-tab" data-toggle="tab"><i class="fa fa-gears"></i></a></li>
    </ul>
    <!-- Tab panes -->
    <div class="tab-content">
      <!-- Home tab content -->
      <div class="tab-pane" id="control-sidebar-home-tab">
        <h3 class="control-sidebar-heading">Recent Activity</h3>
        <ul class="control-sidebar-menu">
          <li>
            <a href="javascript:void(0)">
              <i class="menu-icon fa fa-birthday-cake bg-red"></i>

              <div class="menu-info">
                <h4 class="control-sidebar-subheading">Langdon's Birthday</h4>

                <p>Will be 23 on April 24th</p>
              </div>
            </a>
          </li>
          <li>
            <a href="javascript:void(0)">
              <i class="menu-icon fa fa-user bg-yellow"></i>

              <div class="menu-info">
                <h4 class="control-sidebar-subheading">Frodo Updated His Profile</h4>

                <p>New phone +1(800)555-1234</p>
              </div>
            </a>
          </li>
          <li>
            <a href="javascript:void(0)">
              <i class="menu-icon fa fa-envelope-o bg-light-blue"></i>

              <div class="menu-info">
                <h4 class="control-sidebar-subheading">Nora Joined Mailing List</h4>

                <p>nora@example.com</p>
              </div>
            </a>
          </li>
          <li>
            <a href="javascript:void(0)">
              <i class="menu-icon fa fa-file-code-o bg-green"></i>

              <div class="menu-info">
                <h4 class="control-sidebar-subheading">Cron Job 254 Executed</h4>

                <p>Execution time 5 seconds</p>
              </div>
            </a>
          </li>
        </ul>
        <!-- /.control-sidebar-menu -->

        <h3 class="control-sidebar-heading">Tasks Progress</h3>
        <ul class="control-sidebar-menu">
          <li>
            <a href="javascript:void(0)">
              <h4 class="control-sidebar-subheading">
                Custom Template Design
                <span class="label label-danger pull-right">70%</span>
              </h4>

              <div class="progress progress-xxs">
                <div class="progress-bar progress-bar-danger" style="width: 70%"></div>
              </div>
            </a>
          </li>
          <li>
            <a href="javascript:void(0)">
              <h4 class="control-sidebar-subheading">
                Update Resume
                <span class="label label-success pull-right">95%</span>
              </h4>

              <div class="progress progress-xxs">
                <div class="progress-bar progress-bar-success" style="width: 95%"></div>
              </div>
            </a>
          </li>
          <li>
            <a href="javascript:void(0)">
              <h4 class="control-sidebar-subheading">
                Laravel Integration
                <span class="label label-warning pull-right">50%</span>
              </h4>

              <div class="progress progress-xxs">
                <div class="progress-bar progress-bar-warning" style="width: 50%"></div>
              </div>
            </a>
          </li>
          <li>
            <a href="javascript:void(0)">
              <h4 class="control-sidebar-subheading">
                Back End Framework
                <span class="label label-primary pull-right">68%</span>
              </h4>

              <div class="progress progress-xxs">
                <div class="progress-bar progress-bar-primary" style="width: 68%"></div>
              </div>
            </a>
          </li>
        </ul>
        <!-- /.control-sidebar-menu -->

      </div>
      <!-- /.tab-pane -->
      <!-- Stats tab content -->
      <div class="tab-pane" id="control-sidebar-stats-tab">Stats Tab Content</div>
      <!-- /.tab-pane -->
      <!-- Settings tab content -->
      <div class="tab-pane" id="control-sidebar-settings-tab">
        <form method="post">
          <h3 class="control-sidebar-heading">General Settings</h3>

          <div class="form-group">
            <label class="control-sidebar-subheading">
              Report panel usage
              <input type="checkbox" class="pull-right" checked>
            </label>

            <p>
              Some information about this general settings option
            </p>
          </div>
          <!-- /.form-group -->

          <div class="form-group">
            <label class="control-sidebar-subheading">
              Allow mail redirect
              <input type="checkbox" class="pull-right" checked>
            </label>

            <p>
              Other sets of options are available
            </p>
          </div>
          <!-- /.form-group -->

          <div class="form-group">
            <label class="control-sidebar-subheading">
              Expose author name in posts
              <input type="checkbox" class="pull-right" checked>
            </label>

            <p>
              Allow the user to show his name in blog posts
            </p>
          </div>
          <!-- /.form-group -->

          <h3 class="control-sidebar-heading">Chat Settings</h3>

          <div class="form-group">
            <label class="control-sidebar-subheading">
              Show me as online
              <input type="checkbox" class="pull-right" checked>
            </label>
          </div>
          <!-- /.form-group -->

          <div class="form-group">
            <label class="control-sidebar-subheading">
              Turn off notifications
              <input type="checkbox" class="pull-right">
            </label>
          </div>
          <!-- /.form-group -->

          <div class="form-group">
            <label class="control-sidebar-subheading">
              Delete chat history
              <a href="javascript:void(0)" class="text-red pull-right"><i class="fa fa-trash-o"></i></a>
            </label>
          </div>
          <!-- /.form-group -->
        </form>
      </div>
      <!-- /.tab-pane -->
    </div>
  </aside>
  <!-- /.control-sidebar -->
  <!-- Add the sidebar's background. This div must be placed
       immediately after the control sidebar -->
  <div class="control-sidebar-bg"></div>
</div>
<!-- ./wrapper -->

<!-- jQuery 3 -->
<script src="bower_components/jquery/dist/jquery.min.js"></script>
<!-- jQuery UI 1.11.4 -->
<script src="bower_components/jquery-ui/jquery-ui.min.js"></script>
<!-- Resolve conflict in jQuery UI tooltip with Bootstrap tooltip -->
<script>
  $.widget.bridge('uibutton', $.ui.button);
</script>
<!-- Bootstrap 3.3.7 -->
<script src="bower_components/bootstrap/dist/js/bootstrap.min.js"></script>
<!-- Morris.js charts -->
<script src="bower_components/raphael/raphael.min.js"></script>
<script src="bower_components/morris.js/morris.min.js"></script>
<!-- Sparkline -->
<script src="bower_components/jquery-sparkline/dist/jquery.sparkline.min.js"></script>
<!-- jvectormap -->
<script src="plugins/jvectormap/jquery-jvectormap-1.2.2.min.js"></script>
<script src="plugins/jvectormap/jquery-jvectormap-world-mill-en.js"></script>
<!-- jQuery Knob Chart -->
<script src="bower_components/jquery-knob/dist/jquery.knob.min.js"></script>
<!-- daterangepicker -->
<script src="bower_components/moment/min/moment.min.js"></script>
<script src="bower_components/bootstrap-daterangepicker/daterangepicker.js"></script>
<!-- datepicker -->
<script src="bower_components/bootstrap-datepicker/dist/js/bootstrap-datepicker.min.js"></script>
<!-- Bootstrap WYSIHTML5 -->
<script src="plugins/bootstrap-wysihtml5/bootstrap3-wysihtml5.all.min.js"></script>
<!-- Slimscroll -->
<script src="bower_components/jquery-slimscroll/jquery.slimscroll.min.js"></script>
<!-- FastClick -->
<script src="bower_components/fastclick/lib/fastclick.js"></script>
<!-- AdminLTE App -->
<script src="dist/js/adminlte.min.js"></script>
<!-- AdminLTE dashboard demo (This is only for demo purposes) -->
<script src="dist/js/pages/dashboard.js"></script>
<!-- AdminLTE for demo purposes -->
<script src="dist/js/demo.js"></script>
</body>
</html>              