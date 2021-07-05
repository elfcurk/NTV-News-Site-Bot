<!DOCTYPE html>
<html lang="tr">
<head>
    <title>Haber Sınıflandır</title>
    <link rel="icon" href="images/icon.png" type="image/x-icon">

    <link rel="stylesheet" href="css/bootstrap.min.css">
    <link rel="stylesheet" href="css/animate.min.css">
    <link rel="stylesheet" href="css/font-awesome.min.css">
    <link rel="stylesheet" href="css/ionicons.min.css">
    <link rel="stylesheet" href="css/style.css">
    <link href='https://fonts.googleapis.com/css?family=Source+Sans+Pro:400,700,300' rel='stylesheet' type='text/css'>
    <link rel="stylesheet" href="css/uikit.min.css">
    <link rel="stylesheet" href="css/uikit-rtl.min.css">
    <link rel="stylesheet" href="js/uikit.min.js">
    <link rel="stylesheet" href="js/uikit-icons.min.js">
</head>
<body>
<!-- Header section
================================================== -->
<section id="header" class="header-one" >
    <div class="container" >
        <div class="row">

            <div class="col-md-offset-3 col-md-6 col-sm-offset-2 col-sm-8">
                <div class="">
                    <form method="POST">
                        <fieldset class="uk-fieldset">
                            <div class="form-group purple-border">
								<textarea class="form-control" name ="haber" id="exampleFormControlTextarea4" placeholder="Haberinizi yazınız..." rows="8"></textarea>
							</div>
                        </fieldset>
                        <button type="submit" class="btn btn-light uk-button uk-button-default">Sınıflandır</button>
                    </form><br><br>
                    
                    <span class="uk-label">
                        <?php
                        $dunya = 0;
                        $turkiye = 0;
                        $spor = 0;
                        $ekonomi = 0;
                        $secim = 0;
                        if(isset($_POST['haber'])) {
                            $haber = $_POST['haber'];
                            $dizi = explode(' ',$haber);
                            foreach($dizi as $hbr){
                                $hbr=strtolower($hbr);
                                if($hbr != "yerel"){
                                    if($hbr != "kuru"){
                                        if($hbr != "gram"){
                                            if($hbr != "milyar"){
                                                if($hbr != "piyango"){
                                                    if($hbr != "seçim"){
                                                        if($hbr != "yüzde"){
                                                            if($hbr != "hazine"){
                                                                if($hbr != "fenerbahçe"){
                                                                    if($hbr != "galatasaray"){
                                                                        if($hbr != "ak"){
                                                                            if($hbr != "beşiktaş"){
                                                                                if($hbr != "kupası"){
                                                                                    if($hbr != "şampiyonası"){
                                                                                        if($hbr != "lig"){
                                                                                            if($hbr != "teknik"){
                                                                                                if($hbr != "futbol"){
                                                                                                    if($hbr != "belediye"){
                                                                                                        if($hbr != "iftar"){
                                                                                                            if($hbr != "fetö"){
                                                                                                                if($hbr != "ligi"){
                                                                                                                    if($hbr != "ysk"){
                                                                                                                        if($hbr != "akar"){
                                                                                                                            if($hbr != "şehit"){
                                                                                                                                if($hbr != "trabzonspor"){
                                                                                                                                    if($hbr != "kurulu") {
                                                                                                                                        if ($hbr != "merkez") {
                                                                                                                                            if ($hbr != "istanbul") {
                                                                                                                                                if ($hbr != "milli") {
                                                                                                                                                    if ($hbr != "doğu") {
                                                                                                                                                        if ($hbr != "hale") {
                                                                                                                                                            if ($hbr != "ırak") {
                                                                                                                                                                if ($hbr != "verdi") {
                                                                                                                                                                    if ($hbr != "kadar") {
                                                                                                                                                                        if ($hbr != "abd") {
                                                                                                                                                                            if ($hbr != "recep") {
                                                                                                                                                                                if ($hbr != "başkanlığı") {
                                                                                                                                                                                    if ($hbr != "chp") {
                                                                                                                                                                                        if ($hbr != "gözaltı") {
                                                                                                                                                                                            
                                                                                                                                                                                        } else {
                                                                                                                                                                                            $turkiye++;
                                                                                                                                                                                        }
                                                                                                                                                                                    } else {
                                                                                                                                                                                        $turkiye++;
                                                                                                                                                                                    }
                                                                                                                                                                                } else {
                                                                                                                                                                                    $turkiye++;
                                                                                                                                                                                }
                                                                                                                                                                            } else {
                                                                                                                                                                                if ($hbr != "dakika") {
                                                                                                                                                                                    $dunya++;
                                                                                                                                                                                } else {
                                                                                                                                                                                    $turkiye++;
                                                                                                                                                                                }
                                                                                                                                                                            }
                                                                                                                                                                        } else {
                                                                                                                                                                            $dunya++;
                                                                                                                                                                        }
                                                                                                                                                                    } else {
                                                                                                                                                                        if ($hbr != "dedi") {
                                                                                                                                                                            $ekonomi++;
                                                                                                                                                                        } else {
                                                                                                                                                                            $dunya++;
                                                                                                                                                                        }
                                                                                                                                                                    }
                                                                                                                                                                } else {
                                                                                                                                                                    if ($hbr != "başkanı") {
                                                                                                                                                                        $spor++;
                                                                                                                                                                    } else {
                                                                                                                                                                        $dunya++;
                                                                                                                                                                    }
                                                                                                                                                                }
                                                                                                                                                            } else {
                                                                                                                                                                if ($hbr != "ta") {
                                                                                                                                                                    $turkiye++;
                                                                                                                                                                } else {
                                                                                                                                                                    $dunya++;
                                                                                                                                                                }
                                                                                                                                                            }
                                                                                                                                                        } else {
                                                                                                                                                            if ($hbr != "bir") {
                                                                                                                                                                $turkiye++;
                                                                                                                                                            } else {
                                                                                                                                                                $dunya++;
                                                                                                                                                            }
                                                                                                                                                        }
                                                                                                                                                    } else {
                                                                                                                                                        $turkiye++;
                                                                                                                                                    }

                                                                                                                                                } else {
                                                                                                                                                    if ($hbr != "başkanlığı") {
                                                                                                                                                        $spor++;
                                                                                                                                                    } else {
                                                                                                                                                        $turkiye++;
                                                                                                                                                    }
                                                                                                                                                }
                                                                                                                                            } else {
                                                                                                                                                if ($hbr != "arabistan") {
                                                                                                                                                    $turkiye++;
                                                                                                                                                } else {
                                                                                                                                                    $dunya++;
                                                                                                                                                }
                                                                                                                                            }
                                                                                                                                        }
                                                                                                                                        else{
                                                                                                                                            if($hbr != "ile"){
                                                                                                                                                $ekonomi++;
                                                                                                                                            }
                                                                                                                                            else{
                                                                                                                                                $turkiye++;
                                                                                                                                            }
                                                                                                                                        }
                                                                                                                                    }
                                                                                                                                    else{
                                                                                                                                        if($haber!="bu"){
                                                                                                                                            $spor++;
                                                                                                                                        }
                                                                                                                                        else{
                                                                                                                                            $ekonomi++;
                                                                                                                                        }

                                                                                                                                    }
                                                                                                                                }
                                                                                                                                else{
                                                                                                                                    $spor++;
                                                                                                                                }
                                                                                                                            }
                                                                                                                            else{
                                                                                                                                $turkiye++;
                                                                                                                            }
                                                                                                                        }
                                                                                                                        else{
                                                                                                                            $turkiye++;
                                                                                                                        }
                                                                                                                    }
                                                                                                                    else{
                                                                                                                        if($hbr != "sandık"){
                                                                                                                            $turkiye++;
                                                                                                                        }
                                                                                                                        else{
                                                                                                                            if($hbr != "baskanı"){
                                                                                                                                $secim++;
                                                                                                                            }
                                                                                                                            else{
                                                                                                                                $turkiye++;
                                                                                                                            }
                                                                                                                        }
                                                                                                                    }
                                                                                                                }
                                                                                                                else{
                                                                                                                    $spor++;
                                                                                                                }
                                                                                                            }
                                                                                                            else{
                                                                                                                $turkiye++;
                                                                                                            }
                                                                                                        }
                                                                                                        else{
                                                                                                            $turkiye++;
                                                                                                        }
                                                                                                    }
                                                                                                    else{
                                                                                                        if($hbr != "adayı"){
                                                                                                            $turkiye++;
                                                                                                        }
                                                                                                        else{
                                                                                                            $secim++;
                                                                                                        }
                                                                                                    }
                                                                                                }
                                                                                                else{
                                                                                                    $spor++;
                                                                                                }
                                                                                            }
                                                                                            else{
                                                                                                $spor++;
                                                                                            }
                                                                                        }
                                                                                        else{

                                                                                        }
                                                                                    }
                                                                                    else{
                                                                                        $spor++;
                                                                                    }
                                                                                }
                                                                                else{
                                                                                    $spor++;
                                                                                }
                                                                            }
                                                                            else{
                                                                                $spor++;
                                                                            }
                                                                        }
                                                                        else{
                                                                            if($hbr != "yaptı"){
                                                                                if($hbr != "başkan"){
                                                                                    if($hbr != "ysk"){
                                                                                        $secim++;
                                                                                    }
                                                                                    else{
                                                                                        $turkiye++;
                                                                                    }
                                                                                }
                                                                                else{
                                                                                    $secim++;
                                                                                }
                                                                            }
                                                                            else{
                                                                                $turkiye++;
                                                                            }
                                                                        }
                                                                    }
                                                                    else{
                                                                        $spor++;
                                                                    }
                                                                }
                                                                else{
                                                                    $spor++;
                                                                }
                                                            }
                                                            else{
                                                                if($hbr != "maliye"){
                                                                    $dunya++;
                                                                }
                                                                else{
                                                                    $ekonomi;
                                                                }
                                                            }
                                                        }
                                                        else{
                                                            if($hbr != "belediye"){
                                                                if($hbr != "başkanı"){
                                                                    $ekonomi++;
                                                                }
                                                                else{
                                                                    $dunya++;
                                                                }
                                                            }
                                                            else{
                                                                $turkiye++;
                                                            }
                                                        }
                                                    }
                                                    else{
                                                        if($hbr != "nin"){
                                                            if($hbr != "ile"){
                                                                $secim++;
                                                            }
                                                            else{
                                                                $turkiye++;
                                                            }
                                                        }
                                                        else{
                                                            $turkiye++;
                                                        }
                                                    }
                                                }
                                                else{
                                                    $ekonomi++;
                                                }
                                            }
                                            else{
                                                $ekonomi++;
                                            }
                                        }
                                        else{
                                            $ekonomi++;
                                        }
                                    }
                                    else{
                                        $ekonomi++;
                                    }
                                }
                                else{
                                    if($hbr != "ilişkin"){
                                        $secim++;
                                    }
                                    else{
                                        $turkiye++;
                                    }
                                }

                            }
                            
							if($spor == 0 && $secim == 0 && $ekonomi == 0 && $turkiye == 0){
								if($dunya >0) echo "Dünya Haberleri";
							}
							else{
								echo '<font style="color: black"><b>Haber Kategorisi</b><br></font>';
								$sayilar=array($spor,$secim,$ekonomi,$turkiye);
								$enbuyuk=max($sayilar);
								if($enbuyuk == $spor) echo "Spor Haberleri";
								if($enbuyuk == $secim) echo "Yerel Secim Haberleri";
								if($enbuyuk == $ekonomi) echo "Ekonomi Haberleri";
								if($enbuyuk == $turkiye) echo "Turkiye Haberleri";
								
								
							}
							
							
							
								
                            if(empty($haber)) {
                                echo '<b>Lütfen bir haber yazınız.</b>';
                            } else {
                                
                            }
                        } else {
                            #echo '<b>Haberinizi yazın ve sınıflandır butonuna basın.</b>';
                        }
                        ?>
                        </span>
                </div>
            </div>

        </div>
    </div>
</section>
<!-- Footer section
================================================== -->
<footer style="background-color: white">
    <div  >
        <div class="row">

            <div class="col-md-12 col-sm-12">
                <p class="wow fadeInUp"  data-wow-delay="0.3s">Elif Çürük</p>
                <p class="wow fadeInUp"  data-wow-delay="0.3s">Çalışma <br>...</p>
                <p class="wow fadeInUp"  data-wow-delay="0.3s">Kullanılan Teknolojiler</p>
                <ul class="social-icon wow fadeInUp"  data-wow-delay="0.6s">
                    <li><a href="#" ><img src="images/teknoloji.png"></a></li>
                </ul>    
            </div>
        </div>
    </div>
</footer>
<!-- Javascript 
================================================== -->
<script src="js/jquery.js"></script>
<script src="js/bootstrap.min.js"></script>
<script src="js/isotope.js"></script>
<script src="js/imagesloaded.min.js"></script>
<script src="js/wow.min.js"></script>
<script src="js/custom.js"></script>
</body>
</html>