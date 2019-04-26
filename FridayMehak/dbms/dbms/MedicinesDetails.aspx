<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MedicinesDetails.aspx.cs" Inherits="dbms.MedicinesDetails" %>




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
                <li><a runat="server" href="Home.aspx">Home</a></li>
                <li><a runat="server" href="Home.aspx">Sign Out</a></li>
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
       
           <li><a href="Search.aspx"><i class="fa fa-search"></i> <span>Search Medicines</span></a></li>
          <li><a href="MedicinesDetails.aspx"><i class="fa fa-book"></i> <span>Medicines Detail</span></a></li>

        <li class="treeview active menu-open">
          <a href="#">
            <i class="fa fa-edit"></i> <span>Reports</span>
            <span class="pull-right-container">
              <i class="fa fa-angle-left pull-right"></i>
            </span>
          </a>
          <ul class="treeview-menu">
            <li><a href="Profit.aspx"><i class="fa fa-circle-o"></i> Profit or Loss</a></li>
                <li><a href="Sold-Medicines.aspx"><i class="fa fa-circle-o"></i> Sold Medicines daily</a></li>
                <li><a href="Expiry-Medicines.aspx"><i class="fa fa-circle-o"></i> Expiry Medicines</a></li>
                <li><a href="Alert.aspx"><i class="fa fa-circle-o"></i> Remaining Medicines Stock</a></li>
                <li><a href="Excessively.aspx"><i class="fa fa-circle-o"></i> Excessively Medicines Sold</a></li>
               <li><a href="Medicines-Weekly.aspx"><i class="fa fa-circle-o"></i> Sold Medicines Weekely</a></li>
               <li><a href="Medicine-Yearly.aspx"><i class="fa fa-circle-o"></i> Sold Medicines Yearly</a></li>
            <%--<li class="active"><a href="advanced.html"><i class="fa fa-circle-o"></i> Advanced Elements</a></li>
            <li><a href="editors.html"><i class="fa fa-circle-o"></i> Editors</a></li>--%>
          </ul>

             <li><a href="invoice.aspx"><i class=" fa-credit-card"></i> <span>Invoice</span></a></li>
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
        <b>Medicines</b>
        
      </h1>
      
    </section>
    <!-- Content Header (Page header) -->
    <section class="content-header">
         <form id="frm" runat="server">
        <asp:Label ID="lblName" runat="server" Text="Medicine Name" Font-Bold="true"></asp:Label><br />
        <asp:TextBox ID="txtName" runat="server" Width="400px"></asp:TextBox><br /><br />


       <asp:Label ID="lblComposition" runat="server" Text="Composition"  Font-Bold="true"></asp:Label><br />
      <asp:TextBox ID="txtComposition" runat="server" Width="400px"></asp:TextBox><br /><br />




       <asp:Label ID="lblDescription" runat="server" Text="Description" Font-Bold="true"></asp:Label><br />
          <asp:TextBox ID="txtdescription" runat="server" Width="400px"></asp:TextBox><br /><br />

              <asp:Label ID="lblSideEffects" runat="server" Text="Side Effects" Font-Bold="true"></asp:Label><br />
          <asp:TextBox ID="txtSideEffects" runat="server" Width="400px"></asp:TextBox><br /><br />

              <asp:Label ID="lblCompany" runat="server" Text="Company" Font-Bold="true"></asp:Label><br />
          <asp:TextBox ID="txtCompany" runat="server" Width="400px"></asp:TextBox><br /><br />

              <asp:Label ID="lblMedCode" runat="server" Text="Medicine Code" Font-Bold="true"></asp:Label><br />
          <asp:TextBox ID="txtMedCode" runat="server" Width="400px"></asp:TextBox><br /><br />


              <asp:Label ID="lblPurchasePrice" runat="server" Text="Purchase Price" Font-Bold="true"></asp:Label><br />
          <asp:TextBox ID="txtPurchasePrice" runat="server" Width="400px"></asp:TextBox><br /><br />


              <asp:Label ID="lblQuantity" runat="server" Text="Quantity" Font-Bold="true"></asp:Label><br />
          <asp:TextBox ID="txtQuantity" runat="server" Width="400px"></asp:TextBox><br /><br />

             <asp:Label ID="lblAlertQty" runat="server" Text="Alert Quantity" Font-Bold="true"></asp:Label><br />
          <asp:TextBox ID="txtAlertQty" runat="server" Width="400px"></asp:TextBox><br /><br />

              <asp:Label ID="lblTax" runat="server" Text="Tax" Font-Bold="true"></asp:Label><br />
          <asp:TextBox ID="txtTax" runat="server" Width="400px"></asp:TextBox><br /><br />

            


             <asp:Label ID="lblCreatedDate" runat="server" Text="Created Date" Font-Bold="true"  ></asp:Label><br />
                    
                 <asp:Calendar ID="Calendar1" runat="server" Visible="false" OnSelectionChanged="Calendar1_SelectionChanged"></asp:Calendar> 
               <asp:TextBox ID="TextBox1" runat="server" AutoPostBack="True" Width="400px"></asp:TextBox>  <br />
               <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Pick Date</asp:LinkButton><br /><br />


             <asp:Label ID="lblPurchaseDate" runat="server" Text="Purchased Date" Font-Bold="true"  ></asp:Label><br />
              <asp:Calendar ID="Calendar2" runat="server" Visible="false" OnSelectionChanged="Calendar2_SelectionChanged"></asp:Calendar> 
             <asp:TextBox ID="TextBox2" runat="server" AutoPostBack="True" Width="400px"></asp:TextBox>  <br />
             <asp:LinkButton ID="LinkButton2" runat="server" OnClick="LinkButton2_Click">Pick Date</asp:LinkButton><br /><br />

                    

             <asp:Label ID="Label1" runat="server" Text="Expiry Date" Font-Bold="true"  ></asp:Label><br />
              <asp:Calendar ID="Calendar3" runat="server" Visible="false" OnSelectionChanged="Calendar3_SelectionChanged"></asp:Calendar> 
             <asp:TextBox ID="TextBox3" runat="server" AutoPostBack="True" Width="400px"></asp:TextBox>  <br />
             <asp:LinkButton ID="LinkButton3" runat="server" OnClick="LinkButton3_Click">Pick Date</asp:LinkButton><br /><br />







         <asp:Button ID="cmdSaveRecord" runat="server" Text="Save Record" BorderStyle="Groove" BackColor="RoyalBlue" Height="35px" OnClick="Button1_Click"  />
       <br /><br />
         <asp:Label ID="lblSaveRecord" runat="server" Text="" ForeColor="Blue" ></asp:Label>
            

            

            
         </form>
                    
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
