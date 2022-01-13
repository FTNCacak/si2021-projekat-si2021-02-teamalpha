<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Web_Presentation_Layer.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <!-- META TAGS -->
    <meta charset="utf-8"/>
    <meta name="viewport" content="width=device-width, initial-scale=1"/>

    <!-- CSS LINKING -->
    <link href="https://cdn.jsdelivr.net/npm/bootstrap-icons@1.5.0/font/bootstrap-icons.css" rel="stylesheet"/>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC" crossorigin="anonymous" />
    <link href="CSS/style.css" rel="stylesheet" />

    <title>Prijava</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <!-- NAVIGATION -->
            <nav class="navbar navbar-expand-lg navbar-dark bg-dark sticky-top">
                <div class="container px-5">
                    <a class="navbar-brand" href="Default.aspx">
                        <img src="Images/LogoWhiteAB.png" height="30" alt="logo" />
                    </a>
                    <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation"><span class="navbar-toggler-icon"></span></button>
                    <div class="collapse navbar-collapse" id="navbarSupportedContent">
                        <ul class="navbar-nav ms-auto mb-2 mb-lg-0">
                            <li class="nav-item"><a class="nav-link" href="Default.aspx">Početna</a></li>
                            <li class="nav-item"><a class="nav-link active" href="Login.aspx">Prijava</a></li>
                            <li class="nav-item"><a class="nav-link" href="Registration.aspx">Registracija</a></li>
                        </ul>
                    </div>
                </div>
            </nav>
            <!-- LOGIN SECTION -->
            <div class="container" ">
                <div class="row align-items-center" style="height: 90vh">
                    <div class="col-lg-6 col-xl-6 mx-auto">
                        <div class="card flex-row my-5 border-0 shadow rounded-3 overflow-hidden">
                            <div class="card-body p-4 p-sm-5">
                                <h5 class="card-title text-center mb-5 fw-light fs-5">Prijavi se</h5>
                                <div>
                                    <div class="form-floating mb-3">
                                        <input runat="server" type="email" class="form-control" id="floatingEmail" placeholder="" required="required" autofocus="autofocus"/>
                                        <label for="floatingEmail">Email</label>
                                    </div>
                                    <div class="form-floating mb-3">
                                        <input runat="server" type="password" class="form-control" placeholder="" id="floatingPassword"/>
                                        <label for="floatingPassword">Lozinka</label>
                                    </div>                                       
                                    <div class="d-grid mb-2">                                        
                                        <asp:LinkButton ID="LoginBtn" runat="server" CssClass="btn btn-lg btn-primary btn-login fw-bold text-uppercase" OnClick="LoginBtn_Click">Otvori nalog</asp:LinkButton>
                                    </div>
                                    <a class="d-block text-center mt-3 small" href="Register.aspx">Registruj novi nalog</a>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </form>

    <!-- JAVASCRIPT LINKING -->
    <script src="https://cdn.jsdelivr.net/npm/@popperjs/core@2.10.2/dist/umd/popper.min.js" integrity="sha384-7+zCNj/IqJ95wo16oMtfsKbZ9ccEh31eOz1HGyDuCQ6wgnyJNSYdrPa03rtR1zdB" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.min.js" integrity="sha384-QJHtvGhmr9XOIpI6YVutG+2QOK9T+ZnN4kzFN1RtK3zEFEIsxhlmWl5/YESvpZ13" crossorigin="anonymous"></script>
</body>
</html>
