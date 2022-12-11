(function ($) {
 "use strict";

/*----------------------------
 jQuery MeanMenu
------------------------------ */
	jQuery('nav#dropdown').meanmenu();	

/*----------------------------
  smoot scroll nav
  ------------------------------ */  
jQuery("#nav").onePageNav({
  scrollOffset:70
});

/*----------------------------
 wow js active
------------------------------ */
 new WOW().init();

 
   
/*----------------------------
 service-slide
------------------------------ */  
  $(".service-slide").owlCarousel({
      autoPlay: true, 
	  slideSpeed:3000,
	  pagination:false,
	  navigation:true,	  
      items :3,
	  /* transitionStyle : "fade", */    /* [This code for animation ] */
	  navigationText:["<i class='fa fa-angle-left'></i>","<i class='fa fa-angle-right'></i>"],
      itemsDesktop : [1199,3],
	  itemsDesktopSmall : [980,2],
	  itemsTablet: [768,1],
	  itemsMobile : [479,1],
  });

/*----------------------------
theme-slide
------------------------------ */  
  $(".theme-slide, .slide-testimonial, .slide-list").owlCarousel({
      autoPlay: true, 
	  slideSpeed:3000,
	  pagination:true,
	  navigation:false,	  
      items :1,
	  /* transitionStyle : "fade", */    /* [This code for animation ] */
	  navigationText:["<i class='fa fa-angle-left'></i>","<i class='fa fa-angle-right'></i>"],
      itemsDesktop : [1199,1],
	  itemsDesktopSmall : [980,1],
	  itemsTablet: [768,1],
	  itemsMobile : [479,1],
  });

/*----------------------------
slide-team
------------------------------ */  
  $(".slide-team, .relatedmember-list").owlCarousel({
      autoPlay: true, 
	  slideSpeed:5000,
	  pagination:false,
	  navigation:true,	  
      items :3,
	  /* transitionStyle : "fade", */    /* [This code for animation ] */
	  navigationText:["<i class='fa fa-angle-left'></i>","<i class='fa fa-angle-right'></i>"],
      itemsDesktop : [1199,3],
	  itemsDesktopSmall : [980,2],
	  itemsTablet: [768,1],
	  itemsMobile : [479,1],
  });

/*----------------------------
slide-blog
------------------------------ */  
  $(".slide-blog").owlCarousel({
      autoPlay: true, 
	  slideSpeed:3000,
	  pagination:false,
	  navigation:true,	  
      items :3,
	  /* transitionStyle : "fade", */    /* [This code for animation ] */
	  navigationText:["<i class='fa fa-angle-left'></i>","<i class='fa fa-angle-right'></i>"],
      itemsDesktop : [1199,3],
	  itemsDesktopSmall : [980,2],
	  itemsTablet: [768,2],
	  itemsMobile : [479,1],
  });

/*----------------------------
slide-review
------------------------------ */  
  $(".slide-review").owlCarousel({
      autoPlay: true, 
	  slideSpeed:3000,
	  pagination:false,
	  navigation:true,	  
      items :1,
	  /* transitionStyle : "fade", */    /* [This code for animation ] */
	  navigationText:["<i class='fa fa-angle-left'></i>","<i class='fa fa-angle-right'></i>"],
      itemsDesktop : [1199,1],
	  itemsDesktopSmall : [980,1],
	  itemsTablet: [768,1],
	  itemsMobile : [479,1],
  });

/*----------------------------
feauter-list
------------------------------ */  
  $(".feauter-list").owlCarousel({
      autoPlay: true, 
	  slideSpeed:3000,
	  pagination:false,
	  navigation:false,	  
      items :1,
	  /* transitionStyle : "fade", */    /* [This code for animation ] */
	  navigationText:["<i class='fa fa-angle-left'></i>","<i class='fa fa-angle-right'></i>"],
      itemsDesktop : [1199,1],
	  itemsDesktopSmall : [980,1],
	  itemsTablet: [768,1],
	  itemsMobile : [479,1],
  });

/*----------------------------
member-list
------------------------------ */  
  $(".member-list, .blog-list").owlCarousel({
      autoPlay: true, 
	  slideSpeed:3000,
	  pagination:false,
	  navigation:false,	  
      items :3,
	  /* transitionStyle : "fade", */    /* [This code for animation ] */
	  navigationText:["<i class='fa fa-angle-left'></i>","<i class='fa fa-angle-right'></i>"],
      itemsDesktop : [1199,3],
	  itemsDesktopSmall : [980,2],
	  itemsTablet: [768,1],
	  itemsMobile : [479,1],
  });


	/*---------------------------
	progress bar 
	-----------------------------*/
	$('.progress-skill').appear(function(){
	  	$('#bar2').barfiller({
		    // color of bar
		    barColor: '#9ce12e',
		    // shows a tooltip
		    tooltip: true,
		    // duration in ms
		    duration: 5000,
		    // re-animate on resize
		    animateOnResize: true,

		    // custom symbol
		    symbol: "%"
		    
		  });  

	  	$('#bar3').barfiller({
		    // color of bar
		    barColor: '#0dc0c0',
		    // shows a tooltip
		    tooltip: true,
		    // duration in ms
		    duration: 5000,
		    // re-animate on resize
		    animateOnResize: true,

		    // custom symbol
		    symbol: "%"
		    
		  }); 

	  	$('#bar4').barfiller({
		    // color of bar
		    barColor: '#ff647a',
		    // shows a tooltip
		    tooltip: true,
		    // duration in ms
		    duration: 5000,
		    // re-animate on resize
		    animateOnResize: true,

		    // custom symbol
		    symbol: "%"
		    
		  }); 

	  	$('#bar5').barfiller({
		    // color of bar
		    barColor: '#e1c12e',
		    // shows a tooltip
		    tooltip: true,
		    // duration in ms
		    duration: 5000,
		    // re-animate on resize
		    animateOnResize: true,

		    // custom symbol
		    symbol: "%"
		    
		  }); 

	  	$('#bar6').barfiller({
		    // color of bar
		    barColor: '#e1c12e',
		    // shows a tooltip
		    tooltip: true,
		    // duration in ms
		    duration: 5000,
		    // re-animate on resize
		    animateOnResize: true,

		    // custom symbol
		    symbol: "%"
		    
		  });

	  	$('#bar7').barfiller({
		    // color of bar
		    barColor: '#e1c12e',
		    // shows a tooltip
		    tooltip: true,
		    // duration in ms
		    duration: 5000,
		    // re-animate on resize
		    animateOnResize: true,

		    // custom symbol
		    symbol: "%"
		    
		  });

	  	$('#bar8').barfiller({
		    // color of bar
		    barColor: '#e1c12e',
		    // shows a tooltip
		    tooltip: true,
		    // duration in ms
		    duration: 5000,
		    // re-animate on resize
		    animateOnResize: true,

		    // custom symbol
		    symbol: "%"
		    
		  });

	  	$('#bar9').barfiller({
		    // color of bar
		    barColor: '#e1c12e',
		    // shows a tooltip
		    tooltip: true,
		    // duration in ms
		    duration: 5000,
		    // re-animate on resize
		    animateOnResize: true,

		    // custom symbol
		    symbol: "%"
		    
		  });
	});
  	

	/*--------------------------
 	scrollUp
	---------------------------- */	
	$.scrollUp({
        scrollText: '<i class="fa fa-angle-up"></i>',
        easingType: 'linear',
        scrollSpeed: 900,
        animation: 'fade'
    });
    
	/*--------------------------
	jquery Sticky Header
	---------------------------- */
	$(window).on('scroll', function(){
	  if( $(window).scrollTop()>80 ){
	    $('#sticky').addClass('stick');
	  } else {
	    $('#sticky').removeClass('stick');
	  }
	}); 

    /*------------------------------------
	 jquery Serch Box activation code 
	 --------------------------------------*/
	 $(".search-button").on('click', function(){
	    $(".search-text").slideToggle('slow');
	});

 /*------------------------------------
 SideSlide menu Activation
 -------------------------------------*/       
    $('#slideBotton').on('click',function(){
        $('#sideSlide').addClass( "highlight" );
    });
    
    $('.close').on('click',function(){
        $('#sideSlide').removeClass( "highlight" );
    }); 
 
	/*-------------------------
   jQuery Page Loader
   --------------------------*/
   $("#loading").delay(2000).fadeOut(500);
   
    /*---------------------------
   	home two portfolio
   	-----------------------------*/
   	 $(".portfolio-list").mixItUp({
   		'animation' : {
   			'animation' : true, 
   			'effects' : 'rotateX translateZ scale'
   		}
   	});
   	 
   	/*---------------------------
   magnificPopup
   	-----------------------------*/
   	 $('.gallery-item').magnificPopup({
	  type: 'image',
	  gallery:{
	    enabled:true
	  }
	});

   	 /*---------------------------
   	counter up
   	-----------------------------*/
   	$('.counter-time').appear(function(){
   		$('.timer').countTo({
   			refreshInterval:10,
   		});
   	}); 
   	
})(jQuery); 