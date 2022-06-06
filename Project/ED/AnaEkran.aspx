<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AnaEkran.aspx.cs" Inherits="ED.AnaEkran" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>E-Dilekçe Online Dilekçe Takip Sistemi</title>
    <link href="tasarim.css" rel="stylesheet" />
    <style type="text/css">
        .auto-style1 {
            width: 193px;
        }
        .auto-style2 {
            height: 176px;
        }
        .auto-style3 {
            left: -3px;
            top: 502px;
        }
    </style>

        <link rel="stylesheet" href="Slider/themes/default/default.css" type="text/css" media="screen" />
        <link rel="stylesheet" href="SLider/nivo-slider.css" type="text/css" media="screen" />
        <script src="http://ajax.googleapis.com/ajax/libs/jquery/1.9.1/jquery.min.js"></script>
        <script type="text/javascript" src="Slider/jquery.nivo.slider.js"></script>
        
        <script type="text/javascript">
                                    $(window).load(function() {
                                        $('#slider').nivoSlider({
                                            effect: 'random',
                                            slices: 3,
                                            boxCols: 8,
                                            boxRows: 4,
                                            animSpeed: 500,
                                            pauseTime: 4000,
                                            startSlide: 0,
                                            directionNav: false,
                                            controlNav: false,
                                            controlNavThumbs: false,
                                            pauseOnHover: true,
                                            manualAdvance: false,
                                            prevText: 'Prev',
                                            nextText: 'Next',
                                            randomStart: true,
                                            beforeChange: function () { },
                                            afterChange: function () { },
                                            slideshowEnd: function () { },
                                            lastSlide: function () { },
                                            afterLoad: function () { }
                                        });
                                                                });
                                </script>

</head>
<body>
    <form id="form1" runat="server">
        <table width="100%">
            <tr>
                <td class="auto-style1">

                    <a href="AnaEkran.aspx"><img src="Images/logo.png" class="auto-style2"/></a>
                    <td>
                        <div id="slider" class="Slider/nivoSlider" > 
                                
                                <img src="Slider/demo/images/ornekdilekceler.png" data-thumb="images/ornekdilekceler.png" alt="" title="Dilekce yazmanın en kolay yolu !" />
                                <img src="Slider/demo/images/f067.jpg" data-thumb="images/f067.jpg"data-transition="slideInLeft" title="Dilekçelerinizi artık dijital ortamdan kolay bir şekilde gönderebileceksiniz."/>
                                <img src="Slider/demo/images/fb-share-v01.jpg" data-thumb="images/fb-share-v01.jpg" alt="" title="E-Dilekçe yakında E-Devlet Kapısı'nda.Detaylar www.turkiye.gov.tr" />

                        </div>
                    </td>
                </td>
            </tr>
        </table>
        <table width="100%">
           
            <tr>
                
                <td align="center">
                    
                    
                    <a id="kurumgir" href="Gorunumler/KurumGiris.aspx"><b>KURUM GİRİŞİ İÇİN TIKLAYINIZ</b></a>
                    
                    
                </td>
                <td align="center">
                    
                    <a id="gorevgir" href="Gorunumler/GorevliGiris.aspx"><b>GÖREVLİ GİRİŞİ İÇİN TIKLAYINIZ</b></a>
                </td>
                    
            </tr>
            
        </table>
                    
    </form>
    <div>
        <table>
        <tr><td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td></tr>
        </table>
    </div>
    <div id="footer2" class="auto-style3">
    <table width="100%">
        <tr height="10px">
                    <td align="center" bgcolor="dcdcdc" >
                        <p> <font size="2" face="Times-New Roman" color="363636"><b>E-Dilekçe © 2016 – 2017 - Kayseri</b></p>
                    </td>
                
            </tr>
    </table>
        </div>
    
                        
                    
</body>
</html>