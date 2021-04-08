




<!DOCTYPE html>
<html lang="en">
  <head>
    <meta charset="utf-8">
  <link rel="dns-prefetch" href="https://github.githubassets.com">
  <link rel="dns-prefetch" href="https://avatars0.githubusercontent.com">
  <link rel="dns-prefetch" href="https://avatars1.githubusercontent.com">
  <link rel="dns-prefetch" href="https://avatars2.githubusercontent.com">
  <link rel="dns-prefetch" href="https://avatars3.githubusercontent.com">
  <link rel="dns-prefetch" href="https://github-cloud.s3.amazonaws.com">
  <link rel="dns-prefetch" href="https://user-images.githubusercontent.com/">



  <link crossorigin="anonymous" media="all" integrity="sha512-aZYk5AYsRiFiFG04Si6FnQoHFwAugnodzKJXgafKqPWsrgrjoWRsapCn//vFuWqjSzr72ucZfPq8/ZbduuSeQg==" rel="stylesheet" href="https://github.githubassets.com/assets/frameworks-next-699624e4062c462162146d384a2e859d.css" />
  
    <link crossorigin="anonymous" media="all" integrity="sha512-Cekoa8NJPFI0Iq0DXeaj7mZZnmNquqYhskN2PglQ273quAM3sf8Ca9DY1h92qY+Tf933lAyJAC2VxNhE5kUPXQ==" rel="stylesheet" href="https://github.githubassets.com/assets/github-next-09e9286bc3493c523422ad035de6a3ee.css" />
    
    
    
    


  <meta name="viewport" content="width=device-width">
  
  <title>PhilipsHueSDK-iOS-OSX/RGB to xy Color conversion.md at 00187a3db88dedd640f5ddfa8a474458dff4e1db · PhilipsHue/PhilipsHueSDK-iOS-OSX</title>
    <meta name="description" content="The Software Development Kit for Philips Hue on iOS and OS X (beta) - PhilipsHue/PhilipsHueSDK-iOS-OSX">
    <link rel="search" type="application/opensearchdescription+xml" href="/opensearch.xml" title="GitHub">
  <link rel="fluid-icon" href="https://github.com/fluidicon.png" title="GitHub">
  <meta property="fb:app_id" content="1401488693436528">
  <meta name="apple-itunes-app" content="app-id=1477376905">

    <meta name="twitter:image:src" content="https://avatars1.githubusercontent.com/u/2989748?s=400&amp;v=4" /><meta name="twitter:site" content="@github" /><meta name="twitter:card" content="summary" /><meta name="twitter:title" content="PhilipsHue/PhilipsHueSDK-iOS-OSX" /><meta name="twitter:description" content="The Software Development Kit for Philips Hue on iOS and OS X (beta) - PhilipsHue/PhilipsHueSDK-iOS-OSX" />
    <meta property="og:image" content="https://avatars1.githubusercontent.com/u/2989748?s=400&amp;v=4" /><meta property="og:site_name" content="GitHub" /><meta property="og:type" content="object" /><meta property="og:title" content="PhilipsHue/PhilipsHueSDK-iOS-OSX" /><meta property="og:url" content="https://github.com/PhilipsHue/PhilipsHueSDK-iOS-OSX" /><meta property="og:description" content="The Software Development Kit for Philips Hue on iOS and OS X (beta) - PhilipsHue/PhilipsHueSDK-iOS-OSX" />

  <link rel="assets" href="https://github.githubassets.com/">
      <link rel="shared-web-socket" href="wss://live.github.com/_luau/eyJ2IjoiVjMiLCJ1IjoyNDYxODkzNCwicyI6NTUwNzgzMTAyLCJjIjozMTY3NTkwMDY4LCJ0IjoxNTkzMDY3Mjk3fQ==--3a0d9c99d3ecdbab0f3c944ce3fb5aeb5fd8fb569fa5a04cc915a1cce1f9dad4" data-refresh-url="/_ws">
  <link rel="sudo-modal" href="/sessions/sudo_modal">

  <meta name="request-id" content="D2A9:53EE:845464:DCED4C:5EF4471B" data-pjax-transient="true" /><meta name="html-safe-nonce" content="0c1696ed7bee70bcd3794880961e794c0e306a69" data-pjax-transient="true" /><meta name="visitor-payload" content="eyJyZWZlcnJlciI6Imh0dHBzOi8vZ2l0aHViLmNvbS9QaGlsaXBzSHVlL1BoaWxpcHNIdWVTREstaU9TLU9TWC9maW5kLzAwMTg3YTNkYjg4ZGVkZDY0MGY1ZGRmYThhNDc0NDU4ZGZmNGUxZGIiLCJyZXF1ZXN0X2lkIjoiRDJBOTo1M0VFOjg0NTQ2NDpEQ0VENEM6NUVGNDQ3MUIiLCJ2aXNpdG9yX2lkIjoiODE2NDA4ODY4MDY4Mzk0Njg2NCIsInJlZ2lvbl9lZGdlIjoiaWFkIiwicmVnaW9uX3JlbmRlciI6ImlhZCJ9" data-pjax-transient="true" /><meta name="visitor-hmac" content="56f12498ed0b229ecda5d51eabb40dc93751451804c3b2601ab4f99cb652e0ec" data-pjax-transient="true" />



  <meta name="github-keyboard-shortcuts" content="repository,source-code" data-pjax-transient="true" />

  

  <meta name="selected-link" value="repo_source" data-pjax-transient>

    <meta name="google-site-verification" content="c1kuD-K2HIVF635lypcsWPoD4kilo5-jA_wBFyT4uMY">
  <meta name="google-site-verification" content="KT5gs8h0wvaagLKAVWq8bbeNwnZZK1r1XQysX3xurLU">
  <meta name="google-site-verification" content="ZzhVyEFwb7w3e0-uOTltm8Jsck2F5StVihD0exw2fsA">
  <meta name="google-site-verification" content="GXs5KoUUkNCoaAZn7wPN-t01Pywp9M3sEjnt_3_ZWPc">

<meta name="octolytics-host" content="collector.githubapp.com" /><meta name="octolytics-app-id" content="github" /><meta name="octolytics-event-url" content="https://collector.githubapp.com/github-external/browser_event" /><meta name="octolytics-dimension-ga_id" content="" class="js-octo-ga-id" /><meta name="octolytics-actor-id" content="24618934" /><meta name="octolytics-actor-login" content="sombraguerrero" /><meta name="octolytics-actor-hash" content="cc5b878cd3b4b6f473f4354bbc118142b0d8d965ddbf6ed94e2abbe3ce1b2917" />
<meta name="analytics-location" content="/&lt;user-name&gt;/&lt;repo-name&gt;/blob/show" data-pjax-transient="true" />


<meta name="optimizely-datafile" content="{}" />

    <meta name="google-analytics" content="UA-3769691-2">

  <meta class="js-ga-set" name="userId" content="6b6e0c5d3d975e2d4d71f21dad772a6b">

<meta class="js-ga-set" name="dimension10" content="Responsive" data-pjax-transient>

<meta class="js-ga-set" name="dimension1" content="Logged In">



  

      <meta name="hostname" content="github.com">
    <meta name="user-login" content="sombraguerrero">


      <meta name="expected-hostname" content="github.com">

      <meta name="js-proxy-site-detection-payload" content="OTY5MjM5MWM1ZDgwOGFmZDFjMzE2OTUyZmI0Njk4YmM1YWQ2OWIwYWZhYWZkNDQwOGM4YWY0ZGMwNTFlNzY5Y3x7InJlbW90ZV9hZGRyZXNzIjoiNzYuMTcuMjMyLjE3NyIsInJlcXVlc3RfaWQiOiJEMkE5OjUzRUU6ODQ1NDY0OkRDRUQ0Qzo1RUY0NDcxQiIsInRpbWVzdGFtcCI6MTU5MzA2NzI5NywiaG9zdCI6ImdpdGh1Yi5jb20ifQ==">

    <meta name="enabled-features" content="MARKETPLACE_PENDING_INSTALLATIONS,PAGE_STALE_CHECK,PRIMER_NEXT">

  <meta http-equiv="x-pjax-version" content="3e3a000e8b83f3b908bb717baea69649">
  

      <link href="https://github.com/PhilipsHue/PhilipsHueSDK-iOS-OSX/commits/00187a3db88dedd640f5ddfa8a474458dff4e1db.atom" rel="alternate" title="Recent Commits to PhilipsHueSDK-iOS-OSX:00187a3db88dedd640f5ddfa8a474458dff4e1db" type="application/atom+xml">

  <meta name="go-import" content="github.com/PhilipsHue/PhilipsHueSDK-iOS-OSX git https://github.com/PhilipsHue/PhilipsHueSDK-iOS-OSX.git">

  <meta name="octolytics-dimension-user_id" content="2989748" /><meta name="octolytics-dimension-user_login" content="PhilipsHue" /><meta name="octolytics-dimension-repository_id" content="8654659" /><meta name="octolytics-dimension-repository_nwo" content="PhilipsHue/PhilipsHueSDK-iOS-OSX" /><meta name="octolytics-dimension-repository_public" content="true" /><meta name="octolytics-dimension-repository_is_fork" content="false" /><meta name="octolytics-dimension-repository_network_root_id" content="8654659" /><meta name="octolytics-dimension-repository_network_root_nwo" content="PhilipsHue/PhilipsHueSDK-iOS-OSX" /><meta name="octolytics-dimension-repository_explore_github_marketplace_ci_cta_shown" content="false" />


    <link rel="canonical" href="https://github.com/PhilipsHue/PhilipsHueSDK-iOS-OSX/blob/00187a3db88dedd640f5ddfa8a474458dff4e1db/ApplicationDesignNotes/RGB%20to%20xy%20Color%20conversion.md" data-pjax-transient>


  <meta name="browser-stats-url" content="https://api.github.com/_private/browser/stats">

  <meta name="browser-errors-url" content="https://api.github.com/_private/browser/errors">

  <link rel="mask-icon" href="https://github.githubassets.com/pinned-octocat.svg" color="#000000">
  <link rel="alternate icon" class="js-site-favicon" type="image/png" href="https://github.githubassets.com/favicons/favicon.png">
  <link rel="icon" class="js-site-favicon" type="image/svg+xml" href="https://github.githubassets.com/favicons/favicon.svg">

<meta name="theme-color" content="#1e2327">

  <meta name="msapplication-TileImage" content="/windows-tile.png">
  <meta name="msapplication-TileColor" content="#ffffff">

  <link rel="manifest" href="/manifest.json" crossOrigin="use-credentials">

  </head>

  <body class="logged-in env-production page-responsive page-blob">
      
  <div id="readme" class="Box-body readme blob js-code-block-container p-5 p-xl-6">
    <article class="markdown-body entry-content container-lg" itemprop="text"><p>#Conversion between RGB and xy in the CIE 1931 colorspace for hue
The conversion between RGB and xy in the CIE 1931 colorspace is not something Philips invented, but we have an optimized conversion for our different light types, like hue bulbs and LivingColors.
It is important to differentiate between the various light types, because they do not all support the same color gamut. For example, the hue bulbs are very good at showing nice whites, while the LivingColors are generally a bit better at colors, like green and cyan.</p>
<p>In the PHUtility class contained in the Hue iOS SDK <a href="https://github.com/PhilipsHue/PhilipsHueSDKiOS">https://github.com/PhilipsHue/PhilipsHueSDKiOS</a> you can see our Objective-C implementation of these transformations, which is used in our iOS SDK for hue.</p>
<p>The method signature for converting from xy values and brightness to a color is:</p>
<pre><code>+ (UIColor *)colorFromXY:(CGPoint)xy andBrightness:(float)brightness forModel:(NSString*)model
</code></pre>
<p>The method signature for converting from a color to xy and brightness values:</p>
<pre><code>+ (void)calculateXY:(CGPoint *)xy andBrightness:(float *)brightness fromColor:(UIColor *)color forModel:(NSString*)model
</code></pre>
<p>The color to xy/brightness does not return a value, instead takes two pointers to variables which it will change to the appropriate values.</p>
<p>The model parameter of both methods is the modelNumber value of a PHLight object. The advantage of this model being settable is that you can decide if you want to limit the color of all lights to a certain model, or that every light should do the colors within its own range.</p>
<p>Current Philips lights have a color gamut defined by 3 points, making it a triangle.</p>
<p>For the hue bulb the corners of the triangle are:
Red: 0.675, 0.322
Green: 0.4091, 0.518
Blue: 0.167, 0.04</p>
<p>For LivingColors Bloom, Aura and Iris the triangle corners are:
Red: 0.704, 0.296
Green: 0.2151, 0.7106
Blue: 0.138, 0.08</p>
<p>If you have light which is not one of those, you should use:
Red: 1.0, 0
Green: 0.0, 1.0
Blue: 0.0, 0.0</p>
<p>Color to xy
We start with the color to xy conversion, which we will do in a couple of steps:</p>
<ol>
<li>
<p>Get the RGB values from your color object and convert them to be between 0 and 1.
So the RGB color (255, 0, 100) becomes (1.0, 0.0, 0.39)</p>
</li>
<li>
<p>Apply a gamma correction to the RGB values, which makes the color more vivid and more the like the color displayed on the screen of your device.
This gamma correction is also applied to the screen of your computer or phone, thus we need this to create the same color on the light as on screen.
This is done by the following formulas:
float red = (red   &gt; 0.04045f) ? pow((red   + 0.055f) / (1.0f + 0.055f), 2.4f) : (red   / 12.92f);
float green = (green &gt; 0.04045f) ? pow((green + 0.055f) / (1.0f + 0.055f), 2.4f) : (green / 12.92f);
float blue = (blue  &gt; 0.04045f) ? pow((blue  + 0.055f) / (1.0f + 0.055f), 2.4f) : (blue  / 12.92f);</p>
</li>
<li>
<p>Convert the RGB values to XYZ using the Wide RGB D65 conversion formula
The formulas used:</p>
<p>float X = red * 0.649926f + green * 0.103455f + blue * 0.197109f;</p>
<p>float Y = red * 0.234327f + green * 0.743075f + blue * 0.022598f;</p>
<p>float Z = red * 0.0000000f + green * 0.053077f + blue * 1.035763f;</p>
</li>
<li>
<p>Calculate the xy values from the XYZ values</p>
<p>float x = X / (X + Y + Z);</p>
<p>float y = Y / (X + Y + Z);</p>
</li>
<li>
<p>Check if the found xy value is within the color gamut of the light, if not continue with step 6, otherwise step 7
When we sent a value which the light is not capable of, the resulting color might not be optimal. Therefor we try to only sent values which are inside the color gamut of the selected light.</p>
</li>
<li>
<p>Calculate the closest point on the color gamut triangle and use that as xy value
The closest value is calculated by making a perpendicular line to one of the lines the triangle consists of and when it is then still not inside the triangle, we choose the closest corner point of the triangle.</p>
</li>
<li>
<p>Use the Y value of XYZ as brightness
The Y value indicates the brightness of the converted color.</p>
</li>
</ol>
<p>xy to color
The xy to color conversion is almost the same, but in reverse order.</p>
<ol>
<li>
<p>Check if the xy value is within the color gamut of the lamp, if not continue with step 2, otherwise step 3
We do this to calculate the most accurate color the given light can actually do.</p>
</li>
<li>
<p>Calculate the closest point on the color gamut triangle and use that as xy value
See step 6 of color to xy.</p>
</li>
<li>
<p>Calculate XYZ values
Convert using the following formulas:</p>
<p>float x = x; // the given x value</p>
<p>float y = y; // the given y value</p>
<p>float z = 1.0f - x - y;</p>
<p>float Y = brightness; // The given brightness value</p>
<p>float X = (Y / y) * x;</p>
<p>float Z = (Y / y) * z;</p>
</li>
<li>
<p>Convert to RGB using Wide RGB D65 conversion (THIS IS A D50 conversion currently)</p>
<p>float r = X  * 1.4628067f - Y * 0.1840623f - Z * 0.2743606f;</p>
<p>float g = -X * 0.5217933f + Y * 1.4472381f + Z * 0.0677227f;</p>
<p>float b = X  * 0.0349342f - Y * 0.0968930f + Z * 1.2884099f;</p>
</li>
<li>
<p>Apply reverse gamma correction</p>
<p>r = r &lt;= 0.0031308f ? 12.92f * r : (1.0f + 0.055f) * pow(r, (1.0f / 2.4f)) - 0.055f;</p>
<p>g = g &lt;= 0.0031308f ? 12.92f * g : (1.0f + 0.055f) * pow(g, (1.0f / 2.4f)) - 0.055f;</p>
<p>b = b &lt;= 0.0031308f ? 12.92f * b : (1.0f + 0.055f) * pow(b, (1.0f / 2.4f)) - 0.055f;</p>
</li>
<li>
<p>Convert the RGB values to your color object
The rgb values from the above formulas are between 0.0 and 1.0.</p>
</li>
</ol>
<p>Further Information
The following links provide further useful related information</p>
<p>sRGB:</p>
<p><a href="http://en.wikipedia.org/wiki/Srgb" rel="nofollow">http://en.wikipedia.org/wiki/Srgb</a></p>
<p>A Review of RGB Color Spaces:</p>
<p><a href="http://www.babelcolor.com/download/A%20review%20of%20RGB%20color%20spaces.pdf" rel="nofollow">http://www.babelcolor.com/download/A%20review%20of%20RGB%20color%20spaces.pdf</a></p>
</article>
  </div>

    </div>

  </body>
</html>

