<!DOCTYPE html>
<html lang="es" data-product-locale="es-la">
  <head>
      <link id="figma_preload_user_state" rel="preload" as="fetch" crossorigin="anonymous" href="&#47;api&#47;user&#47;state?team_id=1611499336180272008&amp;file_key=JOqNr4rqgbjiQg1wSZBwLo&amp;fuid=1611499334421898866"/>
      <link id="figma_preload_session_state" rel="preload" as="fetch" crossorigin="anonymous" href="&#47;api&#47;session&#47;state?fuid=1611499334421898866"/>
    <script nonce="8wZUP&#47;bM2tMogCHqp7Om3w==">performance.mark('figma:bootstrap:preload-start-http')</script>

    <meta charset="utf-8">

    <meta name="entrypoint_variant" content="figma_app" />

    <meta name="is_preload_streaming" content="true" />

        <meta name="twitter:card" content="player">
    <meta name="twitter:site" content="@figma">
    <meta name="twitter:title" content="Podcast app for horror stories">
    <meta name="twitter:player" content="https://www.figma.com/embed?embed_host=twitter&url=https:&#47;&#47;www.figma.com&#47;make&#47;JOqNr4rqgbjiQg1wSZBwLo&#47;Podcast-app-for-horror-stories?p=f&amp;t=5fHwkbx4NtGGd6IN-0">
    <meta name="twitter:player:width" content="800">
    <meta name="twitter:player:height" content="450">
    <meta name="twitter:image" content="https:&#47;&#47;www.figma.com&#47;file&#47;JOqNr4rqgbjiQg1wSZBwLo&#47;thumbnail?ver=thumbnails%2F84423e8c-d716-43a7-a9e1-7694264a2efe&amp;t=5fHwkbx4NtGGd6IN-0">

    <meta property="og:url" content="https:&#47;&#47;www.figma.com&#47;file&#47;JOqNr4rqgbjiQg1wSZBwLo&#47;Podcast-app-for-horror-stories" />
    <meta property="og:description" content="Created with Figma" />
    <meta property="og:image" content="https:&#47;&#47;www.figma.com&#47;file&#47;JOqNr4rqgbjiQg1wSZBwLo&#47;thumbnail?ver=thumbnails%2F84423e8c-d716-43a7-a9e1-7694264a2efe&amp;t=5fHwkbx4NtGGd6IN-0">
    <meta property="og:image:width" content="800" />
    <meta property="og:image:height" content="707" />
    <meta property="og:image:user_generated" content="true" />
    <meta property="og:type" content="article" />
    <meta property="og:article:published_time" content="2026-03-05 21:24:08 UTC" />
    <meta property="og:article:modified_time" content="2026-03-10 05:42:39 UTC" />
    <meta property="og:article:section" content="Design" />

    <meta name="description" content="Created with Figma" >

    <link rel="alternate" type="application/json+oembed" href="https:&#47;&#47;www.figma.com&#47;api&#47;oembed?url=https:&#47;&#47;www.figma.com&#47;make&#47;JOqNr4rqgbjiQg1wSZBwLo&#47;Podcast-app-for-horror-stories?p=f&amp;t=5fHwkbx4NtGGd6IN-0" title="OEmbed" />

      <script nonce="8wZUP/bM2tMogCHqp7Om3w==">
        function isSupportedBrowser() {
          const isCSSLayerSupported = typeof CSSLayerBlockRule !== 'undefined'

          let isIntlListFormatSupported = true
          try {
            new Intl.ListFormat()
          } catch {
            isIntlListFormatSupported = false
          }


          const checks = [
            isCSSLayerSupported,
            isIntlListFormatSupported,
            window.WebGL2RenderingContext !== undefined,
            window.WeakRef !== undefined,
          ]
          // The browser is supported if all checks pass
          return checks.every(v => v)
        }
        if (!isSupportedBrowser()) {
          window.isUnsupportedBrowser = true
          location.href = '/unsupported_browser'
        }
      </script>

    
<style nonce="8wZUP&#47;bM2tMogCHqp7Om3w==">

@font-face {
  font-family: 'Inter';
  font-style: normal;
  font-weight: 400;
  src:
    url(https://fonts.gstatic.com/s/inter/v2/UcCO3FwrK3iLTeHuS_fvQtMwCp50KnMw2boKoduKmMEVuLyfAZFhjA.eot?#)
      format('eot'),
    url(https://fonts.gstatic.com/s/inter/v2/UcCO3FwrK3iLTeHuS_fvQtMwCp50KnMw2boKoduKmMEVuLyfAZ9hiA.woff2)
      format('woff2'),
    url(https://fonts.gstatic.com/s/inter/v2/UcCO3FwrK3iLTeHuS_fvQtMwCp50KnMw2boKoduKmMEVuLyfAZFhjg.woff)
      format('woff');
}

@font-face {
  font-family: 'Inter';
  font-style: normal;
  font-weight: 600;
  src:
    url(https://fonts.gstatic.com/s/inter/v2/UcCO3FwrK3iLTeHuS_fvQtMwCp50KnMw2boKoduKmMEVuGKYAZFhjA.eot?#)
      format('eot'),
    url(https://fonts.gstatic.com/s/inter/v2/UcCO3FwrK3iLTeHuS_fvQtMwCp50KnMw2boKoduKmMEVuGKYAZ9hiA.woff2)
      format('woff2'),
    url(https://fonts.gstatic.com/s/inter/v2/UcCO3FwrK3iLTeHuS_fvQtMwCp50KnMw2boKoduKmMEVuGKYAZFhjg.woff)
      format('woff');
}

@font-face {
  font-family: 'Apercu';
  font-style: italic;
  font-weight: 200;
  src:
    url(https://static.figma.com/blog/fonts/Apercu-LightItalic.eot?#iefix) format('embedded-opentype'),
    url(https://static.figma.com/blog/fonts/Apercu-LightItalic.woff2) format('woff2'),
    url(https://static.figma.com/blog/fonts/Apercu-LightItalic.ttf) format('truetype');
}

@font-face {
  font-family: 'Apercu';
  font-style: normal;
  font-weight: 200;
  src:
    url(https://static.figma.com/blog/fonts/Apercu-Light.eot?#iefix) format('embedded-opentype'),
    url(https://static.figma.com/blog/fonts/Apercu-Light.woff2) format('woff2'),
    url(https://static.figma.com/blog/fonts/Apercu-Light.ttf) format('truetype');
}

@font-face {
  font-family: 'Apercu';
  font-style: normal;
  font-weight: 400;
  src:
    url(https://static.figma.com/blog/fonts/Apercu-Regular.eot?#iefix) format('embedded-opentype'),
    url(https://static.figma.com/blog/fonts/Apercu-Regular.woff2) format('woff2'),
    url(https://static.figma.com/blog/fonts/Apercu-Regular.ttf) format('truetype');
}

@font-face {
  font-family: 'Apercu';
  font-style: italic;
  font-weight: 400;
  src:
    url(https://static.figma.com/blog/fonts/Apercu-RegularItalic.eot?#iefix)
      format('embedded-opentype'),
    url(https://static.figma.com/blog/fonts/Apercu-RegularItalic.woff2) format('woff2'),
    url(https://static.figma.com/blog/fonts/Apercu-RegularItalic.ttf) format('truetype');
}

@font-face {
  font-family: 'Apercu';
  font-style: normal;
  font-weight: 500;
  src:
    url(https://static.figma.com/blog/fonts/Apercu-Medium.eot?#iefix) format('embedded-opentype'),
    url(https://static.figma.com/blog/fonts/Apercu-Medium.woff2) format('woff2'),
    url(https://static.figma.com/blog/fonts/Apercu-Medium.ttf) format('truetype');
}

@font-face {
  font-family: 'Apercu';
  font-style: italic;
  font-weight: 500;
  src:
    url(https://static.figma.com/blog/fonts/Apercu-MediumItalic.eot?#iefix) format('embedded-opentype'),
    url(https://static.figma.com/blog/fonts/Apercu-MediumItalic.woff2) format('woff2'),
    url(https://static.figma.com/blog/fonts/Apercu-MediumItalic.ttf) format('truetype');
}

@font-face {
  font-family: 'Apercu-Mono';
  font-style: normal;
  font-weight: 400;
  src:
    url(https://static.figma.com/blog/fonts/Apercu-Mono.eot?#iefix) format('embedded-opentype'),
    url(https://static.figma.com/blog/fonts/Apercu-Mono.woff2) format('woff2'),
    url(https://static.figma.com/blog/fonts/Apercu-Mono.ttf) format('truetype');
}







@font-face {
  font-family: 'D7CBI';
  font-style: italic;
  font-weight: 400;
  src:
    url(https://static.figma.com/webfont/1/DSEG7Classic-Italic-Custom2.woff2) format('woff2'),
    url(https://static.figma.com/webfont/1/DSEG7Classic-Italic-Custom2.woff) format('woff');
}

@font-face {
  font-family: 'D7CBIB';
  font-style: italic;
  font-weight: 700;
  src:
    url(https://static.figma.com/uploads/ebb2329c34e943b5ff793ecbca7fd432fb93f8c6) format('woff2'),
    url(https://static.figma.com/uploads/06688d40b7d52b25111a4d495f45e6584f7e65cb) format('woff');
}


@font-face {
  font-family: 'Figma Sans';
  font-style: normal;
  font-weight: 300;
  src:
    url(https://static.figma.com/webfont/1/Figma-Standard-Text-Light.woff2) format('woff2'),
    url(https://static.figma.com/webfont/1/Figma-Standard-Text-Light.woff) format('woff');
}

@font-face {
  font-family: 'Figma Sans';
  font-style: oblique;
  font-weight: 300;
  src:
    url(https://static.figma.com/webfont/1/Figma-Standard-Text-Light-Oblique.woff2) format('woff2'),
    url(https://static.figma.com/webfont/1/Figma-Standard-Text-Light-Oblique.woff) format('woff');
}

@font-face {
  font-family: 'Figma Sans';
  font-style: normal;
  font-weight: 400;
  src:
    url(https://static.figma.com/webfont/1/Figma-Standard-Text-Regular.woff2) format('woff2'),
    url(https://static.figma.com/webfont/Figma-Standard-Text-Regular.woff) format('woff');
}

@font-face {
  font-family: 'Figma Sans';
  font-style: oblique;
  font-weight: 400;
  src:
    url(https://static.figma.com/webfont/1/Figma-Standard-Text-Regular-Oblique.woff2)
      format('woff2'),
    url(https://static.figma.com/webfont/Figma-Standard-Text-Regular-Oblique.woff) format('woff');
}

@font-face {
  font-family: 'Figma Sans';
  font-style: normal;
  font-weight: 500;
  src:
    url(https://static.figma.com/webfont/1/Figma-Standard-Text-Medium.woff2) format('woff2'),
    url(https://static.figma.com/webfont/1/Figma-Standard-Text-Medium.woff) format('woff');
}

@font-face {
  font-family: 'Figma Sans';
  font-style: oblique;
  font-weight: 500;
  src:
    url(https://static.figma.com/webfont/1/Figma-Standard-Text-Medium-Oblique.woff2) format('woff2'),
    url(https://static.figma.com/webfont/1/Figma-Standard-Text-Medium-Oblique.woff) format('woff');
}

@font-face {
  font-family: 'Figma Sans';
  font-style: normal;
  font-weight: 700;
  src:
    url(https://static.figma.com/webfont/1/Figma-Standard-Text-Bold.woff2) format('woff2'),
    url(https://static.figma.com/webfont/1/Figma-Standard-Text-Bold.woff) format('woff');
}

@font-face {
  font-family: 'Figma Sans';
  font-style: oblique;
  font-weight: 700;
  src:
    url(https://static.figma.com/webfont/1/Figma-Standard-Text-Bold-Oblique.woff2) format('woff2'),
    url(https://static.figma.com/webfont/1/Figma-Standard-Text-Bold-Oblique.woff) format('woff');
}

@font-face {
  font-family: 'Figma Sans';
  font-style: normal;
  font-weight: 900;
  src:
    url(https://static.figma.com/webfont/1/Figma-Standard-Text-Heavy.woff2) format('woff2'),
    url(https://static.figma.com/webfont/1/Figma-Standard-Text-Heavy.woff) format('woff');
}

@font-face {
  font-family: 'Figma Sans';
  font-style: oblique;
  font-weight: 900;
  src:
    url(https://static.figma.com/webfont/1/Figma-Standard-Text-Heavy-Oblique.woff2) format('woff2'),
    url(https://static.figma.com/webfont/1/Figma-Standard-Text-Heavy-Oblique.woff) format('woff');
}

@font-face {
  font-family: 'Figma Mono';
  font-style: normal;
  font-weight: 300;
  src:
    url(https://static.figma.com/webfont/1/Figma-Mono-Light.woff2) format('woff2'),
    url(https://static.figma.com/webfont/1/Figma-Mono-Light.woff) format('woff');
}

@font-face {
  font-family: 'Figma Mono';
  font-style: oblique;
  font-weight: 300;
  src:
    url(https://static.figma.com/webfont/1/Figma-Mono-Light-Oblique.woff2) format('woff2'),
    url(https://static.figma.com/webfont/1/Figma-Mono-Light-Oblique.woff) format('woff');
}

@font-face {
  font-family: 'Figma Mono';
  font-style: normal;
  font-weight: 400;
  src:
    url(https://static.figma.com/webfont/1/Figma-Mono-Regular.woff2) format('woff2'),
    url(https://static.figma.com/webfont/1/Figma-Mono-Regular.woff) format('woff');
}

@font-face {
  font-family: 'Figma Mono';
  font-style: oblique;
  font-weight: 400;
  src:
    url(https://static.figma.com/webfont/1/Figma-Mono-Regular-Oblique.woff2) format('woff2'),
    url(https://static.figma.com/webfont/1/Figma-Mono-Regular-Oblique.woff) format('woff');
}

@font-face {
  font-family: 'Figma Mono';
  font-style: normal;
  font-weight: 500;
  src:
    url(https://static.figma.com/webfont/1/Figma-Mono-Medium.woff2) format('woff2'),
    url(https://static.figma.com/webfont/1/Figma-Mono-Medium.woff) format('woff');
}

@font-face {
  font-family: 'Figma Mono';
  font-style: oblique;
  font-weight: 500;
  src:
    url(https://static.figma.com/webfont/1/Figma-Mono-Medium-Oblique.woff2) format('woff2'),
    url(https://static.figma.com/webfont/1/Figma-Mono-Medium-Oblique.woff) format('woff');
}

@font-face {
  font-family: 'Figma Mono';
  font-style: normal;
  font-weight: 700;
  src:
    url(https://static.figma.com/webfont/1/Figma-Mono-Bold.woff2) format('woff2'),
    url(https://static.figma.com/webfont/1/Figma-Mono-Bold.woff) format('woff');
}

@font-face {
  font-family: 'Figma Mono';
  font-style: oblique;
  font-weight: 700;
  src:
    url(https://static.figma.com/webfont/1/Figma-Mono-Bold-Oblique.woff2) format('woff2'),
    url(https://static.figma.com/webfont/1/Figma-Mono-Bold-Oblique.woff) format('woff');
}

@font-face {
  font-family: 'Figma Mono';
  font-style: normal;
  font-weight: 900;
  src:
    url(https://static.figma.com/webfont/1/Figma-Mono-Heavy.woff2) format('woff2'),
    url(https://static.figma.com/webfont/1/Figma-Mono-Heavy.woff) format('woff');
}

@font-face {
  font-family: 'Figma Mono';
  font-style: oblique;
  font-weight: 900;
  src:
    url(https://static.figma.com/webfont/1/Figma-Mono-Heavy-Oblique.woff2) format('woff2'),
    url(https://static.figma.com/webfont/1/Figma-Mono-Heavy-Oblique.woff) format('woff');
}


@font-face {
  font-family: 'Inter';
  font-weight: 100 900;
  font-style: normal;
  font-named-instance: 'Regular';
  src: url(https://static.figma.com/uploads/2cca21a49f7dad1daa612d73d50357644671964a);
}

@font-face {
  font-family: 'Inter';
  font-weight: 100 900;
  font-style: italic;
  font-named-instance: 'Italic';
  src: url(https://static.figma.com/uploads/43d730c59dee2754d29e0d946ba8cb8339656979)
    format('woff2');
}

@font-face {
  font-family: 'Roboto';
  font-style: normal;
  font-weight: 300;
  src:
    url(https://static.figma.com/webfont/1/Roboto-Light.woff2) format('woff2'),
    url(https://static.figma.com/webfont/1/Roboto-Light.woff) format('woff');
}
@font-face {
  font-family: 'Roboto';
  font-style: normal;
  font-weight: 400;
  src:
    url(https://static.figma.com/webfont/1/Roboto-Regular.woff2) format('woff2'),
    url(https://static.figma.com/webfont/1/Roboto-Regular.woff) format('woff');
}
@font-face {
  font-family: 'Roboto';
  font-style: normal;
  font-weight: 500;
  src:
    url(https://static.figma.com/webfont/1/Roboto-Medium.woff2?v=2) format('woff2'),
    url(https://static.figma.com/webfont/1/Roboto-Medium.woff) format('woff');
}
@font-face {
  font-family: 'Roboto';
  font-style: normal;
  font-weight: 700;
  src:
    url(https://static.figma.com/webfont/1/Roboto-Bold.woff2) format('woff2'),
    url(https://static.figma.com/webfont/1/Roboto-Bold.woff) format('woff');
}
@font-face {
  font-family: 'Roboto Mono';
  font-style: normal;
  font-weight: 400;
  src:
    url(https://static.figma.com/webfont/1/RobotoMono-Regular.woff2) format('woff2'),
    url(https://static.figma.com/webfont/1/RobotoMono-Regular.woff) format('woff');
}
@font-face {
  font-family: 'Roboto Mono';
  font-style: normal;
  font-weight: 700;
  src:
    url(https://static.figma.com/webfont/1/RobotoMono-Bold.woff2) format('woff2'),
    url(https://static.figma.com/webfont/1/RobotoMono-Bold.woff) format('woff');
}



@font-face {
  font-family: 'Whyte';
  font-style: normal;
  font-weight: 400;
  src:
    url(https://static.figma.com/webfont/1/Whyte-Regular.woff) format('woff'),
    url(https://static.figma.com/webfont/1/Whyte-Regular.woff2) format('wof2');
}

@font-face {
  font-family: 'Whyte';
  font-style: normal;
  font-weight: 500;
  src:
    url(https://static.figma.com/webfont/1/Whyte-Medium.woff) format('woff'),
    url(https://static.figma.com/webfont/1/Whyte-Medium.woff2) format('wof2');
}

@font-face {
  font-family: 'Whyte';
  font-style: normal;
  font-weight: 700;
  src:
    url(https://static.figma.com/webfont/1/Whyte-Bold.woff) format('woff'),
    url(https://static.figma.com/webfont/1/Whyte-Bold.woff2) format('wof2');
}

@font-face {
  font-family: 'WhyteInktrap';
  font-style: normal;
  font-weight: 400;
  src:
    url(https://static.figma.com/webfont/1/WhyteInktrap-Regular.woff) format('woff'),
    url(https://static.figma.com/webfont/1/WhyteInktrap-Regular.woff2) format('wof2');
}

@font-face {
  font-family: 'WhyteInktrap';
  font-style: normal;
  font-weight: 700;
  src:
    url(https://static.figma.com/webfont/1/WhyteInktrap-Bold.woff) format('woff'),
    url(https://static.figma.com/webfont/1/WhyteInktrap-Bold.woff2) format('wof2');
}

</style>


      <link rel="preload" as="script" href="https:&#47;&#47;www.figma.com&#47;webpack-artifacts&#47;assets&#47;runtime~figma_app-6654d38182d1a7cd.min.js.br" crossorigin="anonymous" nonce="8wZUP/bM2tMogCHqp7Om3w==" />
      <link rel="preload" as="script" href="https:&#47;&#47;www.figma.com&#47;webpack-artifacts&#47;assets&#47;vendor-core-ade2edecaf4781c7.min.js.br" crossorigin="anonymous" nonce="8wZUP/bM2tMogCHqp7Om3w==" />
      <link rel="preload" as="script" href="https:&#47;&#47;www.figma.com&#47;webpack-artifacts&#47;assets&#47;svg-773ec884034c346e.min.js.br" crossorigin="anonymous" nonce="8wZUP/bM2tMogCHqp7Om3w==" />
      <link rel="preload" as="script" href="https:&#47;&#47;www.figma.com&#47;webpack-artifacts&#47;assets&#47;svg-1243c0722dac1c69.min.js.br" crossorigin="anonymous" nonce="8wZUP/bM2tMogCHqp7Om3w==" />
      <link rel="preload" as="script" href="https:&#47;&#47;www.figma.com&#47;webpack-artifacts&#47;assets&#47;svg-be02c1ffbf0aec0d.min.js.br" crossorigin="anonymous" nonce="8wZUP/bM2tMogCHqp7Om3w==" />
      <link rel="preload" as="script" href="https:&#47;&#47;www.figma.com&#47;webpack-artifacts&#47;assets&#47;svg-8302926740278639.min.js.br" crossorigin="anonymous" nonce="8wZUP/bM2tMogCHqp7Om3w==" />
      <link rel="preload" as="script" href="https:&#47;&#47;www.figma.com&#47;webpack-artifacts&#47;assets&#47;svg-10e6dcec46a9da5b.min.js.br" crossorigin="anonymous" nonce="8wZUP/bM2tMogCHqp7Om3w==" />
      <link rel="preload" as="script" href="https:&#47;&#47;www.figma.com&#47;webpack-artifacts&#47;assets&#47;cssbuilder-4924a9f8a79aa64a.min.js.br" crossorigin="anonymous" nonce="8wZUP/bM2tMogCHqp7Om3w==" />
      <link rel="preload" as="script" href="https:&#47;&#47;www.figma.com&#47;webpack-artifacts&#47;assets&#47;svg-039572250fe3ab4b.min.js.br" crossorigin="anonymous" nonce="8wZUP/bM2tMogCHqp7Om3w==" />
      <link rel="preload" as="script" href="https:&#47;&#47;www.figma.com&#47;webpack-artifacts&#47;assets&#47;svg-e23b98fc45c25527.min.js.br" crossorigin="anonymous" nonce="8wZUP/bM2tMogCHqp7Om3w==" />
      <link rel="preload" as="script" href="https:&#47;&#47;www.figma.com&#47;webpack-artifacts&#47;assets&#47;svg-a337b013ed90d899.min.js.br" crossorigin="anonymous" nonce="8wZUP/bM2tMogCHqp7Om3w==" />
      <link rel="preload" as="script" href="https:&#47;&#47;www.figma.com&#47;webpack-artifacts&#47;assets&#47;svg-2eb127e51a93b20b.min.js.br" crossorigin="anonymous" nonce="8wZUP/bM2tMogCHqp7Om3w==" />
      <link rel="preload" as="script" href="https:&#47;&#47;www.figma.com&#47;webpack-artifacts&#47;assets&#47;vendor-e02619323541de64.min.js.br" crossorigin="anonymous" nonce="8wZUP/bM2tMogCHqp7Om3w==" />
      <link rel="preload" as="script" href="https:&#47;&#47;www.figma.com&#47;webpack-artifacts&#47;assets&#47;vendor-fdcc732e0d2d4c0f.min.js.br" crossorigin="anonymous" nonce="8wZUP/bM2tMogCHqp7Om3w==" />
      <link rel="preload" as="script" href="https:&#47;&#47;www.figma.com&#47;webpack-artifacts&#47;assets&#47;vendor-8113207a091b7299.min.js.br" crossorigin="anonymous" nonce="8wZUP/bM2tMogCHqp7Om3w==" />
      <link rel="preload" as="script" href="https:&#47;&#47;www.figma.com&#47;webpack-artifacts&#47;assets&#47;vendor-61558bc8fb46456d.min.js.br" crossorigin="anonymous" nonce="8wZUP/bM2tMogCHqp7Om3w==" />
      <link rel="preload" as="script" href="https:&#47;&#47;www.figma.com&#47;webpack-artifacts&#47;assets&#47;vendor-5fdbd10ea5780ca3.min.js.br" crossorigin="anonymous" nonce="8wZUP/bM2tMogCHqp7Om3w==" />
      <link rel="preload" as="script" href="https:&#47;&#47;www.figma.com&#47;webpack-artifacts&#47;assets&#47;6691-ea1a3b4571a0f448.min.js.br" crossorigin="anonymous" nonce="8wZUP/bM2tMogCHqp7Om3w==" />
      <link rel="preload" as="script" href="https:&#47;&#47;www.figma.com&#47;webpack-artifacts&#47;assets&#47;406-656fac6d09c8fbc1.min.js.br" crossorigin="anonymous" nonce="8wZUP/bM2tMogCHqp7Om3w==" />
      <link rel="preload" as="script" href="https:&#47;&#47;www.figma.com&#47;webpack-artifacts&#47;assets&#47;5340-ca907fbcb950ef0b.min.js.br" crossorigin="anonymous" nonce="8wZUP/bM2tMogCHqp7Om3w==" />
      <link rel="preload" as="script" href="https:&#47;&#47;www.figma.com&#47;webpack-artifacts&#47;assets&#47;856-de3d583022ec61b8.min.js.br" crossorigin="anonymous" nonce="8wZUP/bM2tMogCHqp7Om3w==" />
      <link rel="preload" as="script" href="https:&#47;&#47;www.figma.com&#47;webpack-artifacts&#47;assets&#47;8222-714b50f6fa462b79.min.js.br" crossorigin="anonymous" nonce="8wZUP/bM2tMogCHqp7Om3w==" />
      <link rel="preload" as="script" href="https:&#47;&#47;www.figma.com&#47;webpack-artifacts&#47;assets&#47;2179-5c54f42e41f9e61d.min.js.br" crossorigin="anonymous" nonce="8wZUP/bM2tMogCHqp7Om3w==" />
      <link rel="preload" as="script" href="https:&#47;&#47;www.figma.com&#47;webpack-artifacts&#47;assets&#47;2438-a12b02b1f2114927.min.js.br" crossorigin="anonymous" nonce="8wZUP/bM2tMogCHqp7Om3w==" />
      <link rel="preload" as="script" href="https:&#47;&#47;www.figma.com&#47;webpack-artifacts&#47;assets&#47;8821-ffaa9436357e524e.min.js.br" crossorigin="anonymous" nonce="8wZUP/bM2tMogCHqp7Om3w==" />
      <link rel="preload" as="script" href="https:&#47;&#47;www.figma.com&#47;webpack-artifacts&#47;assets&#47;1165-0359555f5767163f.min.js.br" crossorigin="anonymous" nonce="8wZUP/bM2tMogCHqp7Om3w==" />
      <link rel="preload" as="script" href="https:&#47;&#47;www.figma.com&#47;webpack-artifacts&#47;assets&#47;1379-7435cf66a2de8919.min.js.br" crossorigin="anonymous" nonce="8wZUP/bM2tMogCHqp7Om3w==" />
      <link rel="preload" as="script" href="https:&#47;&#47;www.figma.com&#47;webpack-artifacts&#47;assets&#47;7554-adace7f193e1e91a.min.js.br" crossorigin="anonymous" nonce="8wZUP/bM2tMogCHqp7Om3w==" />
      <link rel="preload" as="script" href="https:&#47;&#47;www.figma.com&#47;webpack-artifacts&#47;assets&#47;1772-f0a11585c70c1cf5.min.js.br" crossorigin="anonymous" nonce="8wZUP/bM2tMogCHqp7Om3w==" />
      <link rel="preload" as="script" href="https:&#47;&#47;www.figma.com&#47;webpack-artifacts&#47;assets&#47;8804-b1e42bf9ef0b389d.min.js.br" crossorigin="anonymous" nonce="8wZUP/bM2tMogCHqp7Om3w==" />
      <link rel="preload" as="script" href="https:&#47;&#47;www.figma.com&#47;webpack-artifacts&#47;assets&#47;figma_app-b0caec42b9db6be5.min.js.br" crossorigin="anonymous" nonce="8wZUP/bM2tMogCHqp7Om3w==" />





    <script nonce="8wZUP/bM2tMogCHqp7Om3w==">performance?.mark('loadTimings:initialOptionsStart')</script>

<script nonce="8wZUP/bM2tMogCHqp7Om3w==">
Object.assign(window, JSON.parse(document.querySelector('[data-initial]').textContent));

console.log('Running frontend commit', "21aaecf9ee6134ba411fbc2e69956f434721be25");

</script>

<script nonce="8wZUP/bM2tMogCHqp7Om3w==">performance?.mark('figma:bootstrap:earlyJsLoadStart')</script>
  <script nonce="8wZUP/bM2tMogCHqp7Om3w==" data-early-bundle="early">
    
!function(){try{var e="undefined"!=typeof window?window:"undefined"!=typeof global?global:"undefined"!=typeof globalThis?globalThis:"undefined"!=typeof self?self:{},n=(new e.Error).stack;n&&(e._sentryDebugIds=e._sentryDebugIds||{},e._sentryDebugIds[n]="d24aaace-ce81-5fb8-940b-3fdbf97394a4")}catch(e){}}();
(()=>{"use strict";var e={513(e,t){Object.defineProperty(t,"__esModule",{value:!0});var n={DARK_THEME_MEDIA_QUERY:function(){return r},getVisibleTheme:function(){return i}};for(var o in n)Object.defineProperty(t,o,{enumerable:!0,get:n[o]});let r=window.matchMedia("(prefers-color-scheme: dark)");function i(e){return"system"===e?r.matches?"dark":"light":"dark"===e?"dark":"light"}}},t={};function n(o){var r=t[o];if(void 0!==r)return r.exports;var i=t[o]={exports:{}};return e[o](i,i.exports,n),i.exports}n.rv=()=>"1.7.5",n.ruid="bundler=rspack@1.7.5",(()=>{let e,t,o,r;class i extends WebSocket{constructor(e,t,n){super(e,t),this.onCloseCb=n,this.events=[],this._onopen_=null,this._onmessage_=null,this._onclose_=null,this._onerror_=null,super.onopen=this.onOpen,super.onmessage=this.onMessage,super.onclose=this.onClose,super.onerror=this.onError}onOpen(e){this.events.push({event:"onopen",ev:e}),this.flushIfInitialized()}onMessage(e){this.events.push({event:"onmessage",ev:e}),this.flushIfInitialized()}onClose(e){this.onCloseCb?.(),this.events.push({event:"onclose",ev:e}),this.flushIfInitialized()}onError(e){this.events.push({event:"onerror",ev:e}),this.flushIfInitialized()}flushIfInitialized(){if(this._onmessage_&&this._onopen_&&this._onclose_&&this._onerror_)for(;this.events.length>0;){let{event:e,ev:t}=this.events.shift();switch(e){case"onopen":this._onopen_(t);break;case"onmessage":this._onmessage_(t);break;case"onclose":this._onclose_(t);break;case"onerror":this._onerror_(t)}}}set onopen(e){this._onopen_=e,this.flushIfInitialized()}get onopen(){return this._onopen_}set onmessage(e){this._onmessage_=e,this.flushIfInitialized()}get onmessage(){return this._onmessage_}set onclose(e){this._onclose_=e,this.flushIfInitialized()}get onclose(){return this._onclose_}set onerror(e){this._onerror_=e,this.flushIfInitialized()}get onerror(){return this._onerror_}}class s{constructor(){this.queue=[],this.storeErrors=!0}static getInstance(){return s.instance||(s.instance=new s),s.instance}registerError(e){this.queue.push(e)}onerror(e,t,n,o,r){return this.storeErrors&&this.queue.push({message:e,source:t,lineno:n,colno:o,error:r}),!1}drainErrors(){for(let e of(this.storeErrors=!1,this.queue))window.onerror?.(e.message,e.source,e.lineno,e.colno,e.error);this.queue.length=0}init(){return{onerror:this.onerror.bind(this),drainErrors:this.drainErrors.bind(this),registerError:this.registerError.bind(this)}}}let a=s.getInstance(),l=!1,c=!1;window.MONITORING=window.MONITORING||{};let d=window.MONITORING;function w(e,t,n){try{let o=`${n}:connectStart`;performance.mark(o,{startTime:t}),e.addEventListener("open",()=>{let e=`${n}:open`;performance.mark(e),performance.measure(`${n}:connect`,o,e)},{once:!0}),e.addEventListener("message",()=>{let e=`${n}:firstByte`;performance.mark(e),performance.measure(`${n}:firstByte`,o,e)},{once:!0})}catch(e){console.error("Error instrumenting WebSocket timing",e)}}var p=n(513);function u(e){return"dark"===e?"1E1E1E":"F5F5F5"}let f="global-debug-theme-preference";function h(e){if(e){let t=e?.getItem(f);return t||"system"}return null}function m(e){return Array.from(e).map(e=>String.fromCharCode(e.charCodeAt(0)-1)).join("")}let _=Object.freeze("gjhnb"),g=Object.freeze("dispnf.fyufotjpo;00"),I=Object.freeze("np{.fyufotjpo;00"),S=Error,y=String.prototype.includes,O=Object.getOwnPropertyDescriptor(S.prototype,"stack")?.get;performance?.mark("figma:bootstrap:earlyJsExecutionStart"),self.global=self;let{onerror:T,drainErrors:v,registerError:E}=a.init();window.onerror=T,window.drainErrors=v;try{d.earlyVisibilityChangeHandler=()=>{let e=window.performance.now();l||(l=!0,d.firstVisibilityChange={visibilityState:document.visibilityState,time:e}),d.mostRecentVisibilityChange={visibilityState:document.visibilityState,time:e}},window.addEventListener("visibilitychange",d.earlyVisibilityChangeHandler)}catch(e){console.error("Error initializing page visibility listener",e)}try{d.earlyNetworkStatusChangeHandler=()=>{let e=window.performance.now();c||(c=!0,d.firstNetworkStatusChange={networkStatus:window.navigator.onLine?"online":"offline",time:e}),d.mostRecentNetworkStatus={networkStatus:window.navigator.onLine?"online":"offline",time:e}},window.addEventListener("online",d.earlyNetworkStatusChangeHandler),window.addEventListener("offline",d.earlyNetworkStatusChangeHandler)}catch(e){console.error("Error initializing network status listener",e)}"true"===new URLSearchParams(window.location.search).get("api_paywall")&&sessionStorage.setItem("figma_initial_api_paywall","true"),(()=>{var n,s;let a,l,c,d,{file_minimal_user_state:T,mock_user_state_for_tests_json:v,multiplayer_preconnect_options:N,omit_core_data:k,omit_user_state:L,preload_fullscreen_urls:b,should_connect_to_multiplayer:A,api_user_state_path:R,api_session_state_path:P,skip_lg_preload:H}=window.EARLY_ARGS||{};window.INITIAL_OPTIONS||(window.INITIAL_OPTIONS={}),((e,t,n,o,r,i,s)=>{if(e){window.userStateXHR={readyState:4,status:200,responseText:e};return}if(!window.Fig)return;if(o||!window.INITIAL_OPTIONS.user_data){window.startUserStateXHR=()=>{};return}let a=i||"/api/session/state";window.startUserStateXHR=function(e){let t=r;if(!t){t="/api/user/state";var o=[];window.INITIAL_OPTIONS.org_id&&o.push("org_id="+window.INITIAL_OPTIONS.org_id),window.INITIAL_OPTIONS.team_id&&o.push("team_id="+window.INITIAL_OPTIONS.team_id),n&&o.push("omit_core_data=1"),e&&o.push("file_key="+e),0!==o.length&&(t+="?"+o.join("&"))}window.userStateXHR=new XMLHttpRequest,window.userStateXHR.open("GET",t);let i=window.INITIAL_OPTIONS.user_data?.id;i&&window.userStateXHR.setRequestHeader("X-Figma-User-ID",i),window.userStateXHR.send();var s=window.performance?window.performance.now():-1;window.userStateXHR.addEventListener("load",function(){window.userStateXHRDuration=window.performance?window.performance.now()-s:-1},!1),window.sessionStateXHR=new XMLHttpRequest,window.sessionStateXHR.open("GET",a),i&&window.sessionStateXHR.setRequestHeader("X-Figma-User-ID",i),window.sessionStateXHR.send()};let l="/preload-android-proto"===location.pathname||"/file/new"===location.pathname||"/design/new"===location.pathname||"/slides/new"===location.pathname||"/board/new"===location.pathname||"/site/new"===location.pathname||"/buzz/new"===location.pathname||"/rev/new"===location.pathname||"/make/new"===location.pathname,c=window.INITIAL_OPTIONS.editing_file&&window.INITIAL_OPTIONS.editing_file.key;t?window.startUserStateXHR(c):l||window.startUserStateXHR()})(v,!!T,!!k,!!L,R,P);let $=/iPhone|iPad|iPod/.test(navigator.userAgent),C=!!window.EARLY_ARGS?.feature_flags?.livegraph_skip_early_conn_preload;if(!$&&!H&&!C){let e,t,n,o,r,s=(e=window.INITIAL_OPTIONS?.figma_url,t=!!window.EARLY_ARGS?.feature_flags?.livegraph_connect_next,n={clientUrl:window.document.URL},o=window.__figmaDesktop||window.__figmaDesktopGetPopoutAPI?.(),r=window.bellFeedAPI,o?(n.desktop=JSON.stringify(o.appVersion),o.version>=126&&(n.desktopOS=JSON.stringify(o.osVersion))):r&&(n.bell="1",r.version>=8&&(n.desktop=JSON.stringify(r.desktopAppVersion),n.desktopOS=JSON.stringify(r.osVersion))),{url:function(e){let t,n;if(e)try{let o=new URL(e);n=o.protocol,t=o.host}catch(e){}return(void 0===t||void 0===n)&&("admin.staging.figma.com"===(t=window.location.host)||"embed.staging.figma.com"===t?t="staging.figma.com":("admin.figma.com"===t||"embed.figma.com"===t)&&(t="www.figma.com"),n=window.location.protocol),`${"https:"===n?"wss":"ws"}://${t}`}(e),userId:window.INITIAL_OPTIONS?.user_data?.id||null,anonUserId:window.INITIAL_OPTIONS?.anonymous_user_id||null,pageLoadToken:window.INITIAL_OPTIONS?.page_load_token||"",preloadedViews:window.INITIAL_OPTIONS?.livegraph_preload_views||{},commitHash:window.INITIAL_OPTIONS?.release_manifest_git_commit||"missing",clientType:o||r?"desktop":"web",useNext:t,extras:n}),a=new URLSearchParams(s.pageLoadToken);for(let[e,t]of(a.append("userId",s.userId||""),a.append("anonUserId",s.anonUserId||""),a.append("clientType",s.clientType),a.append("commitHash",s.commitHash),a.append("preload",JSON.stringify(s.preloadedViews)),Object.entries(s.extras)))a.append(e,t);a.append("connectionType","initial"),a.append("reconnect","0");let l=s.useNext?"/api/livegraph-next":"/api/livegraph",c=`${s.url}${l}?${a.toString()}`;if(!s.extras.bell)try{let e=performance.now();window.LGEarlyWS=new i(c,void 0,()=>{window.LGEarlyWS=void 0}),w(window.LGEarlyWS,e,"figma:ws:livegraph")}catch(e){console.warn("Early.js Bootstrap Error: LG websocket creation failed",e),console.error(e),E({message:"Early.js Bootstrap Error: LG websocket creation failed",error:e})}}if(n=!1!==A,a=window.INITIAL_OPTIONS.user_data?.id,l=window.INITIAL_OPTIONS.tracking_session_id,c=window.INITIAL_OPTIONS.release_manifest_git_commit,d=null,null!=window.__figmaDesktop?d=window.__figmaDesktop.clientID??null:null!=window.__figmaDesktopGetPopoutAPI&&(d=window.__figmaDesktopGetPopoutAPI().clientID??null),window.mpGlobal={version:function(){if(!window.EARLY_ARGS?.feature_flags?.manifest_commit_sha)return 151;let e=window.location.search;if(e.includes("force-client-version")){let t=new URLSearchParams(e).get("force-client-version");if(t){let e=parseInt(t);if(!isNaN(e)&&e>0)return console.log(`!! Overriding client version to ${e}`),e}}return 151}(),sock:null,msgs:[],perfMetrics:[],shouldConnectToMultiplayer:n,url({fileKey:e,role:t,oauthToken:o,nodeIds:r,suppressDecodeErrors:i,tagForLogging:s,forceViewOnly:w,canvasQuerySkipContainers:p}){if(!n)return"";let u=null;N&&e===N.fileKey&&N.targetFileVersion&&(u=N.targetFileVersion);let f="";("editor"===t||"viewerWithCpp"===t)&&r&&(f+=`&scenegraph-queries-initial-nodes=${r}`);let h=new URLSearchParams(window.location.search),m="true"===h.get("recovery"),_="true"===h.get("merge-on-file-open"),g=h.get("force-dpl-journaled-reconnect");"editor"!==t||N?.forceIncrementalForEditors!==1||m||_?(N?.forceIncrementalForEditors===0||m)&&(f+="&use-incremental-for-editors=0"):f+="&use-incremental-for-editors=1","editor"===t&&(window.EARLY_ARGS?.feature_flags?.incremental_loading_validation||_&&window.EARLY_ARGS?.feature_flags?.incremental_loading_validation_branching)&&(f+="&incremental-loading-validation=1");let I=1;try{let e=JSON.parse(sessionStorage.getItem("reload_times")||"[0]"),t=e[e.length-1];I=+(Date.now()-t<5e3)}catch(e){}let S=p;("prototype"===t||"viewer"===t)&&(S=!0);let y=window.INITIAL_OPTIONS.e2e_traffic,O=window.INITIAL_OPTIONS.e2e_test_name;return`${location.protocol.replace("http","ws")}//${location.host}/api/multiplayer/${e}?role=${t}&tracking_session_id=${l}&version=${this.version}&recentReload=${I}&file-load-streaming-compression`+f+(o?"&oauth_token="+o:"")+(a?`&user-id=${a}`:"")+(u?`&target-file-version=${u}`:"")+(c?`&client_release=${c}`:"")+(i?"&suppress-decode-errors":"")+(s?`&tag-for-logging=${s}`:"")+(y?"&e2e_traffic=true":"")+(O?`&e2e_test_name=${O}`:"")+(w?"&force-view-only":"")+(d?`&clientID=${d}`:"")+(S?"&canvas-query-skip-containers":"")+(null!==g?`&force-dpl-journaled-reconnect=${g}`:"")},DEBUG_THEME_PREFERENCE_KEY:f,DARK_THEME_MEDIA_QUERY:p.DARK_THEME_MEDIA_QUERY,themePreferenceFromLocalStorage:h,getBackgroundColorForTheme:u,getVisibleTheme:p.getVisibleTheme,preconnect(e){if(!1===n)return;if(this.sock){if(e===this.sock.url&&this.sock.readyState!==WebSocket.CLOSED)return;try{this.sock.close()}catch(e){}}let t=performance.now();this.sock=new WebSocket(e),this.sock.binaryType="arraybuffer",w(this.sock,t,"figma:ws:multiplayer"),this.sock.onopen=e=>{this.perfMetrics.push({key:"mp-ws-onopen",ts:performance.now(),nBytes:void 0})},this.sock.onmessage=e=>{let t=new Uint8Array(e.data);this.msgs.push(t),this.perfMetrics.push({key:"mp-ws-onmessage",ts:performance.now(),nBytes:t.length*t.BYTES_PER_ELEMENT})},this.msgs=[],this.perfMetrics=[]}},N&&(N.forceViewOnly=!1,(window.INITIAL_OPTIONS?.cluster_name==="staging"||window.INITIAL_OPTIONS?.cluster_name==="local")&&(function(){let e=null;try{e=window.localStorage}catch(e){}return e})()?.getItem("force-vscode")==="true"?N.forceViewOnly=!0:N.forceViewOnly=window?.location.ancestorOrigins&&[...window.location.ancestorOrigins].some(e=>e.startsWith("vscode-webview://")),mpGlobal.preconnect(mpGlobal.url(N))),!b&&!/FigmaMobile-Android/.test(navigator.userAgent)&&(N?.role==="editor"||N?.role==="viewerWithCpp"||N?.role==="prototype")){let e,t=N?.role==="prototype"?Fig.prototypeLibURLs:Fig.fullscreenURLs,n=fetch(t["compiled_wasm.wasm"]);n.catch(e=>console.error(`Fetching compiled_wasm.wasm failed: ${e}`));let o=(s=t["compiled_wasm.js"],(e=new Promise((e,t)=>{let n,o=((n=document.createElement("script")).type="text/javascript",n.async=!0,n.setAttribute("nonce",window.INITIAL_OPTIONS.csp_nonce),n.crossOrigin="anonymous",n);o.onload=e,o.src=s,document.head.appendChild(o)})).catch(e=>console.error(`Fetching ${s} failed: ${e}`)),e);window.FULLSCREEN_PRELOADS={wasm:n,js:o}}!function(){try{if(window.INITIAL_OPTIONS.e2e_traffic||window.location.pathname.startsWith("/test/interactions"))return;let n=window.INITIAL_OPTIONS.editing_file?.can_edit===!1;Object.defineProperty(window,e||(e=m(_)),{get:()=>{let e,i;if((e=new S,!((i=O?O.call(e):e.stack)&&(null==t&&(t=m(g)),null==o&&(o=m(I)),y.call(i,t)||y.call(i,o))))&&!n)return r},set:e=>{n||(r=null!=e?e:void 0)},configurable:!1,enumerable:!1})}catch(e){}}(),performance?.mark("figma:bootstrap:earlyJsExecutionEnd")})()})()})();

//# debugId=d24aaace-ce81-5fb8-940b-3fdbf97394a4

//# sourceMappingURL=https://admin.figma.com/admin/webpack-artifacts/e6c901395b41ba22f039095e25f096d33ede2c08/early-bcbc21e347c8eac5.min.js.map
  </script>



    <script nonce="8wZUP/bM2tMogCHqp7Om3w==">performance?.mark('loadTimings:initialOptionsEnd')</script>

    <meta name="google" content="notranslate" />
    <meta name="slack-app-id" content="A01N2QYSA81">

    <title>Figma</title>

    <style nonce="8wZUP&#47;bM2tMogCHqp7Om3w==" type="text/css">

  /*
    This should be kept in sync with:
    - GRID_TILE_MIN_WIDTH in web/js/browse/shared/views/items_view/grid_view/grid_view.tsx
    - $gridTileMinWidth in _measurements.css
  */
  :root {
    --file-grid-tile-min-width: 272px;
  }

  #filebrowser-loading-page {
    opacity: 1;
    -webkit-transition: opacity .2s ease-in-out;
  }

  .filebrowser-loading-page-layout {
    display: flex;
    flex-wrap: wrap;

    /* Make sure the loading page is flush with the edges of the page so
       our layout isnt affected by browser default margins/paddings */
    position: absolute;
    top: 48px;
    bottom: 0;
    left: 0;
    right: 0;
    background-color: var(--color-bg, var(--fallback-color-bg, white));
  }

  #loading-content-pane {
    opacity: 1;
    -webkit-transition: opacity .4s ease-in-out;
  }

  #filebrowser-loading-page.fadeOut {
    opacity: 0;
  }

  #filebrowser-loading-page.hidden {
    display: none;
    opacity: 0;
  }

  .filebrowser-loading-page .file-grid.create-file-grid {
    margin: 24px 0px;
    grid-gap: 32px;
    background-color: var(--color-bg, white);
  }

  /* HAX: see loading-page-container in loading_spinner.tsx */
  #loading-page-container .create-file-grid {
    display: none;
    background-color: var(--color-bg, white);
  }
  #loading-page-container .sort-dropdown {
    margin-top: 0px;
  }

 /*
  * HAX: The sidebar is cloned and used independently outside of this
  * page so any styles like `.filebrowser-loading-page .thing` applied
  * to sidebar sub-elements also need a selector like
  * `.filebrowser-loading-sidebar .thing` so that they work outside of
  * this page too.
  */
  .filebrowser-loading-page .row,
  .filebrowser-loading-sidebar .row {
    background-color: var(--color-bg-secondary, #f0f0f0);
    border-radius: 3px;
    height: 16px;
  }

  .filebrowser-loading-page .circle,
  .filebrowser-loading-sidebar .circle {
    border-radius: 3px;
    background-color: var(--color-bg-secondary, #f0f0f0);
    width: 16px;
    height: 16px;
  }

  .filebrowser-loading-page .row .circle,
  .filebrowser-loading-sidebar .row .circle {
    position: relative;
    top: -1px;
    left: -35px;
  }

  .filebrowser-loading-sidebar {
    flex: 0 0 240px;
    width: 240px;
    background-color: var(--color-bg, white);
    padding-top: 16px;
    display: flex;
    flex-direction: column;
  }

  .filebrowser-loading-page .navbar {
    height: 48px;
    width: 100%;
    position: fixed;
    top: 0;
    background-color: var(--color-bg-toolbar, #2C2C2C);
    z-index: 1;
  }

  .filebrowser-loading-sidebar .row {
    width: 85px;
    margin-top: 8px;
    margin-bottom: 12px;
    margin-left: 48px;
  }

  .filebrowser-loading-sidebar .row .circle {
    position: relative;
    top: -1px;
    left: -35px;
  }

  .filebrowser-loading-page .divider,
  .filebrowser-loading-sidebar .divider {
    height: 1px;
    background-color: var(--color-border, rgba(0, 0, 0, 0.1));
    margin-top: 8px;
    margin-bottom: 16px;
    margin-left: 16px;
    margin-right: 16px;
  }

  .filebrowser-loading-sidebar .row:nth-child(7) { width: 40px; }
  .filebrowser-loading-sidebar .row:nth-child(8) { width: 58px; }

  .filebrowser-loading-sidebar .row:nth-last-child(1) { opacity: 0.4; width: 65px; }
  .filebrowser-loading-sidebar .row:nth-last-child(2) { opacity: 0.4; width: 65px; }
  .filebrowser-loading-sidebar .row:nth-last-child(3) { opacity: 0.8; width: 46px; }

  .filebrowser-loading-page .page {
    flex: 1 1;
    box-sizing: border-box;
    border-left: 1px var(--color-border, #e5e5e5) solid;
    display: flex;
    flex-direction: column;
  }

  .filebrowser-loading-page .toolbar {
    border-bottom: 1px var(--color-border, #e5e5e5) solid;
    height: 48px;
  }

  .filebrowser-loading-page .toolbar .item {
    background-color: var(--color-bg-secondary, #f0f0f0);
    border-radius: 3px;
    width: 85px;
    height: 16px;
    margin-left: 32px;
    margin-top: 16px;
  }

  .filebrowser-loading-page .columns {
    flex: 1 1;
    display: flex;
    flex-direction: row-reverse;
    padding-right: 32px;
  }

  @media (max-width: 849px) {
    .filebrowser-loading-page .columns {
      flex-direction: column;
    }

    .filebrowser-loading-page .right-column {
      padding-left: 32px;
    }

    .filebrowser-loading-page .public-header + .columns {
      flex-direction: column-reverse;
    }
  }

  .filebrowser-loading-page .content {
    flex: 1 1;
  }

  .filebrowser-loading-page .sort-dropdown {
    border-radius: 3px;
    width: 86px;
    padding: 16px 32px 32px 32px;
  }

  .filebrowser-loading-page .create-file-tile {
    background-color: var(--color-bg-secondary, white);
    border: 1px solid var(--color-border, #e5e5e5);
    border-radius: 6px;
    display: flex;
    align-items: center;
    height: 72px;
    box-sizing: border-box;
  }

  @media (max-width: 832px) {
    .filebrowser-loading-page .create-file-tile {
      height: 48px;
    }
  }

  @media (max-width: 645px) {
    .filebrowser-loading-page .create-file-tile, .filebrowser-loading-page .sort-dropdown {
      display: none;
    }
  }

  .filebrowser-loading-page .create-file-tile .icon {
    background-color: var(--color-bg-secondary, #f0f0f0);
    border-radius: 2px;
    margin-left: 16px;
    margin-right: 16px;
    height: 24px;
    width: 24px;
  }

  .filebrowser-loading-page .create-file-tile .label {
    background-color: var(--color-bg-secondary, #f0f0f0);
    width: 132px;
    height: 16px;
    border-radius: 3px;
  }

  @media (max-width: 1440px) {
   .filebrowser-loading-page .create-file-tile:nth-last-child(1) {
     display: none;
   }
  }

  .filebrowser-loading-page .tile {
    height: 56px;
    padding-top: 60%;
    position: relative;
  }

  .filebrowser-loading-page .tile .inner {
    position: absolute;
    top: 2px;
    bottom: 2px;
    left: 2px;
    right: 2px;
    border: 1px solid var(--color-border, #e5e5e5);
    border-radius: 6px;
    background-color: var(--color-bg-secondary, #f0f0f0);
  }

  .filebrowser-loading-page .tile .inner .lower {
    height: 56px;
    background-color: var(--color-bg, white);
    position: absolute;
    bottom: 0;
    width: 100%;
    border-radius: 0 0 6px 6px;
  }

  .filebrowser-loading-page .public-grid {
    width: 100%;
    box-sizing: border-box;
    display: grid;
    grid-template-columns: repeat(auto-fill, minmax(var(--file-grid-tile-min-width), 1fr));
    grid-gap: 32px;
    padding-left: 32px;
  }

  @media (max-width: 1023px) {
    .filebrowser-loading-page .public-grid {
      grid-template-columns: 1fr;
    }
  }

  .filebrowser-loading-page .public-grid .tile {
    height: 56px;
    padding-top: 60%;
  }

  .filebrowser-loading-page .public-grid .tile:nth-child(6) { opacity: .8; }
  .filebrowser-loading-page .public-grid .tile:nth-child(7) { opacity: .4; }

  .filebrowser-loading-page .file-grid {
    width: 100%;
    box-sizing: border-box;
    display: grid;
    grid-template-columns: repeat(auto-fill, minmax(var(--file-grid-tile-min-width), 1fr));
    grid-gap: 32px;
    padding-left: 32px;
  }

  .filebrowser-loading-page .file-grid .tile:nth-child(6) { opacity: .8; }
  .filebrowser-loading-page .file-grid .tile:nth-child(7) { opacity: .4; }

  .filebrowser-loading-page .team-grid {
    width: 100%;
    box-sizing: border-box;
    display: grid;
    grid-template-columns: repeat(auto-fill, minmax(264px, 1fr));
    grid-gap: 32px 32px;
    padding: 32px 0 0 32px;
    align-content: start;
  }

  .filebrowser-loading-page .team-tile {
    border: 1px solid var(--color-border, rgba(0, 0, 0, .1));
    border-radius: 6px;
    position: relative;
    padding: 16px;
  }

  .filebrowser-loading-page .team-grid .team-tile:nth-child(6) { opacity: .8; }
  .filebrowser-loading-page .team-grid .team-tile:nth-child(7) { opacity: .4; }

  .filebrowser-loading-page .team-tile .row {
    margin-top: 0;
    margin-left: 0;
    margin-bottom: 0;
  }

  .filebrowser-loading-page .team-tile .row:nth-child(1) {
    width: 32px;
    height: 32px;
  }

  .filebrowser-loading-page .team-tile .row:nth-child(2) {
    width: 65px;
    height: 30px;
    position: absolute;
    top: 17px;
    right: 16px;
    margin-top: 0;
  }

  .filebrowser-loading-page .team-tile .row:nth-child(3) {
    width: 120px;
    margin-top: 20px;
  }
  .filebrowser-loading-page .team-tile .row:nth-child(4) {
    width: 232px;
    margin-top: 12px;
  }
  .filebrowser-loading-page .team-tile .row:nth-child(5) {
    width: 174px;
    margin-top: 8px;
  }

  .filebrowser-loading-page .team-tile .circles {
    display: flex;
    flex-direction: row;
  }

  .filebrowser-loading-page .team-tile .circle {
    top: 0;
    left: 0;
    width: 24px;
    height: 24px;
    margin-right: 8px;
    margin-top: 22px;
  }

  .filebrowser-loading-page .public-header {
    background-color: var(--color-bg-secondary, #f0f0f0);
    width: 100%;
    height: 240px;
    margin-bottom: 80px;
  }

  .filebrowser-loading-page .profile-header {
    background-color: var(--color-bg-secondary, #f0f0f0);
    width: 100%;
    height: 64px;
  }

  .filebrowser-loading-page .profile-grid {
    padding: 32px;
    display: grid;
    grid-template-columns: 1fr 24px 1fr .75fr;
    align-items: end;
  }

  .filebrowser-loading-page .profile-grid .row {
    margin-top: 24px;
  }

  .filebrowser-loading-page .profile-grid div:nth-child(4n+1) { width: 148px; }
  .filebrowser-loading-page .profile-grid div:nth-child(4n+3) { width: 56px; }
  .filebrowser-loading-page .profile-grid div:nth-child(4n+4) { width: 99px; }

  .filebrowser-loading-page .profile-grid div:nth-child(1) { width: 61px; margin-top: 0; }

  .filebrowser-loading-page .profile-grid div:nth-child(5) { width: 61px; margin-top: 32px; }
  .filebrowser-loading-page .profile-grid div:nth-child(7) { width: 69px; }
  .filebrowser-loading-page .profile-grid div:nth-child(8) { width: 51px; }

  .filebrowser-loading-page .profile-grid div:nth-child(9) { margin-top: 36px; }
  .filebrowser-loading-page .profile-grid div:nth-child(11) { width: 69px; }
  .filebrowser-loading-page .profile-grid div:nth-child(12) { width: 72px; }

  .filebrowser-loading-page .profile-grid div:nth-child(25),
  .filebrowser-loading-page .profile-grid div:nth-child(27),
  .filebrowser-loading-page .profile-grid div:nth-child(28) { opacity: .8; }

  .filebrowser-loading-page .profile-grid div:nth-child(29),
  .filebrowser-loading-page .profile-grid div:nth-child(31),
  .filebrowser-loading-page .profile-grid div:nth-child(32) { opacity: .4; }

  @media(max-width: 1000px) {
    .filebrowser-loading-page .profile-grid {
      grid-template-columns: 1fr;
    }

    .filebrowser-loading-page .profile-grid div:nth-child(5),
    .filebrowser-loading-page .profile-grid div:nth-child(6),
    .filebrowser-loading-page .profile-grid div:nth-child(7),
    .filebrowser-loading-page .profile-grid div:nth-child(8),
    .filebrowser-loading-page .profile-grid div:nth-child(4n+2),
    .filebrowser-loading-page .profile-grid div:nth-child(4n+3),
    .filebrowser-loading-page .profile-grid div:nth-child(4n+4) { display: none; }
  }

  .filebrowser-loading-page .project-grid {
    padding-left: 32px;
    display: grid;
    grid-row-gap: 22px;
  }

  .filebrowser-loading-page .project-grid .card {
    border: 1px solid var(--color-border, rgba(0, 0, 0, .1));
    border-radius: 4px;
    box-sizing: border-box;
    height: 178px;
    display: flex;
  }

  .filebrowser-loading-page .project-grid .card:nth-child(3) { opacity: .8; }
  .filebrowser-loading-page .project-grid .card:nth-child(4) { opacity: .4; }

  .filebrowser-loading-page .project-grid .card .left {
    width: 196px;
    margin: 16px;
  }

  .filebrowser-loading-page .project-grid .card .right {
    flex: 1 1;
    display: flex;
    flex-direction: row;
    flex-wrap: wrap;
    overflow: hidden;
    margin: 16px 0;
  }

  .filebrowser-loading-page .project-grid .card .left .row:nth-child(1) { width: 107px; }
  .filebrowser-loading-page .project-grid .card .left .row:nth-child(2) { width: 164px; margin-top: 12px; }
  .filebrowser-loading-page .project-grid .card .left .row:nth-child(3) { width: 145px; margin-top: 8px; }
  .filebrowser-loading-page .project-grid .card .left .row:nth-child(4) { width: 158px; margin-top: 8px; }

  .filebrowser-loading-page .project-grid .card .right .row {
    height: 100%;
    flex: 1 1 196px;
    margin-right: 16px;
    border-radius: 6px;
  }

  .filebrowser-loading-page .right-column {
    flex: 0 0 304px;
    margin-right: 16px;
    margin-top: 16px;
    box-sizing: border-box;
    padding-left: 32px;
  }

  .filebrowser-loading-page .right-column .row:nth-child(1) {
    margin-top: 16px;
    width: 120px;
  }
  .filebrowser-loading-page .right-column .row:nth-child(2) {
    margin-top: 18px;
    width: 272px;
  }
  .filebrowser-loading-page .right-column .row:nth-child(3) {
    margin-top: 8px;
    width: 248px;
  }
  .filebrowser-loading-page .right-column .row:nth-child(4) {
    margin-top: 8px;
    width: 272px;
  }
  .filebrowser-loading-page .right-column .row:nth-child(5) {
    margin-top: 8px;
    width: 256px;
  }
  .filebrowser-loading-page .right-column .row:nth-child(6) {
    margin-top: 8px;
    width: 200px;
  }
  .filebrowser-loading-page .right-column .row:nth-child(7) {
    margin-top: 35px;
    width: 88px;
  }
  .filebrowser-loading-page .right-column .row:nth-child(8) {
    margin-top: 22px;
    margin-left: 51px;
    width: 88px;
    opacity: .8;
  }
  .filebrowser-loading-page .right-column .row:nth-child(9) {
    margin-top: 18px;
    margin-left: 51px;
    width: 88px;
    opacity: .4;
  }

  .filebrowser-loading-page .public-left-column {
    padding: 0 0 32px 32px;
    width: 320px;
  }

  .filebrowser-loading-page .public-left-column .row {
    margin-top: 8px;
  }

  .filebrowser-loading-page .public-left-column .row:nth-child(1) {
    width: 120px;
    margin-top: 0;
  }
  .filebrowser-loading-page .public-left-column .row:nth-child(2) {
    width: 272px;
    margin-top: 18px;
  }
  .filebrowser-loading-page .public-left-column .row:nth-child(3) {
    width: 248px;
  }
  .filebrowser-loading-page .public-left-column .row:nth-child(4) {
    width: 272px;
  }
  .filebrowser-loading-page .public-left-column .row:nth-child(5) {
    width: 256px;
    opacity: .8;
  }
  .filebrowser-loading-page .public-left-column .row:nth-child(6) {
    width: 200px;
    opacity: .4;
  }

  /*
  Note: Make sure any changes here are also duplicated in the fullscreen progress bar
  (.progressBar in progress_bar.css)
  */
  #filebrowser-loading-progress-bar {
    height: 5px;
    /* Z index 6 chosen here so it renders over any nav elements but below any scroll bar or modals */
    z-index: 6;

      background: var(--color-bg-brand, #0D99FF);

    position: absolute;
    left: 0;
    animation: filebrowserloadingProgressBar 10s cubic-bezier(.08,.8,.1,1) forwards;
  }

  @keyframes filebrowserloadingProgressBar {
    from { width: 0; }
    to { width: 100%; }
  }


  @media (max-width: 645px) {
    .filebrowser-loading-sidebar {
      display: none;
    }

    .filebrowser-loading-page .page {
      margin-left: 0;
      width: 100%;
    }

    .filebrowser-loading-page .public-header {
      height: 120px;
    }

    .filebrowser-loading-page .file-grid {
      grid-template-columns: 1fr;
      max-width: 400px;
      margin: 0 auto;
      align-self: center;
    }
  }

</style>


    <style nonce="8wZUP&#47;bM2tMogCHqp7Om3w==" type="text/css">

  /*  PAGE LAYOUT STYLES */
  .fb-page-layout {
    background-color: var(--color-bg, var(--fallback-color-bg, white));
  }

  .fb-flex-row {
    height: 100vh;
    display: flex;
    flex-direction: row;
  }

  .fb-sidebar {
    width: 240px;
    padding-top: 4px;
    display: flex;
    flex-direction: column;
  }

  .fb-sidebar > :nth-last-child(2) {
    opacity: 0.6;
  }

  .fb-sidebar > :nth-last-child(1) {
    opacity: 0.3;
  }

  .fb-page {
    display: flex;
    flex-direction: column;
    flex-grow: 1;
    border-left: 1px var(--color-border) solid;
  }

  .fb-page-content-columns {
    overflow: hidden;
    flex-grow: 1;
    display: flex;
    flex-direction: row;
  }

  .fb-page-content {
    flex-grow: 1;
    overflow: hidden;
    position: relative;
    margin-right: 32px;
  }

  .fb-page-right-column {
    width: 304px;
    margin-top: 24px;
    margin-right: 16px;
    padding-left: 32px;
  }

  .fb-fading-content {
    margin-left: 32px;
  }

  /* This is what applies the fading gradient over the skeletons */
  .fb-fading-content:after {
    position: absolute;
    bottom: 0;
    height: 100%;
    width: 100%;
    content: "";
    background: linear-gradient(to bottom, transparent 50%, var(--color-bg) 100%);
    pointer-events: none;
  }

  /* SIDEBAR STYLES */

  .fb-sidebar-account-and-notifications {
    padding: 8px 12px;
    display: flex;
    flex-direction: row;
    align-items: center;
    gap: 8px;
  }

  .fb-sidebar-searchbar {
    padding: 0 8px;
    margin-top: 4px;
    margin-bottom: 8px;
  }

  .fb-sidebar-row {
    padding: 8px 16px;
    display: flex;
    flex-direction: row;
    align-items: center;
  }

  .fb-sidebar-row :nth-child(2) {
    margin-left: 12px;
  }


  .fb-divider {
    height: 1px;
    background-color: var(--color-border, rgba(0, 0, 0, 0.1));
    width: 100%;
    margin-top: 8px;
    margin-bottom: 10px;
  }


  @media (max-width: 645px) {
    .fb-sidebar {
      display: none;
    }
  }

  /* RIGHT COLUMN STYLES */

  .fb-page-right-column-header {
    margin-bottom: 18px;
  }

  .fb-page-right-column-rows > :not(:first-child) {
    margin-top: 8px;
  }

  .fb-page-right-column-lower {
    margin-top: 35px;
  }

  .fb-page-right-column-user-list {
    margin-top: 22px;
    margin-left: 16px;
    display: flex;
    flex-direction: column;
    gap: 18px;
  }

  .fb-page-right-column-user {
    display: flex;
    flex-direction: row;
    gap: 16px;
  }

  .fb-page-right-column-user:nth-child(2) {
    opacity: 0.6;
  }

  .fb-page-right-column-user:nth-child(3) {
    opacity: 0.3;
  }

  /* Skeleton Item Styles */

  .fb-shrink-0 {
    flex-shrink: 0;
  }

  .fb-circle-16 {
    flex-shrink: 0;
    background-color: var(--color-bg-secondary, #f0f0f0);
    height: 16px;
    width: 16px;
    border-radius: 9999px;
  }

  .fb-circle-24 {
    background-color: var(--color-bg-secondary, #f0f0f0);
    height: 24px;
    width: 24px;
    border-radius: 9999px;
  }

  .fb-rectangle-16 {
    background-color: var(--color-bg-secondary);
    height: 16px;
    border-radius: 3px;
  }

  .fb-rectangle-24 {
    background-color: var(--color-bg-secondary);
    height: 24px;
    border-radius: 3px;
  }

  .fb-rectangle-32 {
    background-color: var(--color-bg-secondary);
    height: 32px;
    border-radius: 8px;
  }

  .fb-rectangle-36 {
    background-color: var(--color-bg-secondary);
    height: 36px;
    border-radius: 3px;
  }

  /* Skeleton Item Width Options */

  .fb-width-16 {
    width: 16px;
  }

  .fb-width-32 {
    width: 32px;
  }

  .fb-width-36 {
    width: 36px;
  }

  .fb-width-50 {
    width: 50px;
  }

  .fb-width-55 {
    width: 55px;
  }

  .fb-width-60 {
    width: 60px;
  }

  .fb-width-70 {
    width: 70px;
  }

  .fb-width-80 {
    width: 80px;
  }

  .fb-width-88 {
    width: 88px;
  }

  .fb-width-100 {
    width: 100px;
  }

  .fb-width-105 {
    width: 105px;
  }

  .fb-width-115 {
    width: 115px;
  }

  .fb-width-120 {
    width: 120px;
  }

  .fb-width-148 {
    width: 148px;
  }

  .fb-width-167 {
    width: 167px;
  }

  .fb-width-180 {
    width: 180px;
  }

  .fb-width-200 {
    width: 200px;
  }

  .fb-width-248 {
    width: 248px;
  }

  .fb-width-256 {
    width: 256px;
  }

  .fb-width-272 {
    width: 272px;
  }

  .fb-width-full {
    width: 100%;
  }

  /* Header Styles */

  .fb-toolbar-48 {
    border-bottom: 1px var(--color-border, #e5e5e5) solid;
    height: 48px;
    display: flex;
    flex-shrink: 0;
    align-items: center;
    padding-left: 32px;
  }

  .fb-toolbar-64 {
    border-bottom: 1px var(--color-border, #e5e5e5) solid;
    height: 64px;
    /* We have 10px above the toolbar in the actual page */
    margin-top: 10px;
    display: flex;
    flex-shrink: 0;
    align-items: center;
    padding-left: 32px;
  }

  .fb-toolbar-84 {
    border-bottom: 1px var(--color-border, #e5e5e5) solid;
    height: 80px;
    /* We have 4px above the toolbar in the actual page */
    margin-top: 4px;
    display: flex;
    flex-shrink: 0;
    align-items: center;
    padding-left: 32px;
  }

  .fb-toolbar-84 :nth-child(2) {
    margin-left: 12px;
  }

  .fb-breadcrumb {
    height: 48px;
    display: flex;
    flex-shrink: 0;
    align-items: center;
    padding-left: 32px;
  }

  .fb-header {
    height: 64px;
    display: flex;
    flex-shrink: 0;
    flex-direction: row;
    align-items: center;
    padding-left: 32px;
  }

  .fb-header :nth-child(2) {
    margin-left: 12px;
  }

  .fb-viewbar {
    padding-left: 32px;
    height: 64px;
    align-items: center;
    display: flex;
    flex-direction: row;
    justify-content: space-between;
  }

  /* Page Content: Tile Grid */

  .fb-tile-grid {
    display: grid;
    gap: 32px;
    justify-items: stretch;
    /* Keep this grid template in line with the grid-template-columns in `shared/views/items_view/grid_view/grid_view.tsx` */
    grid-template-columns: repeat(auto-fill, minmax(272px, 1fr));
  }

  .fb-tile-grid-top-padding {
    margin-top: 24px;
  }

  .fb-file-tile-DEPRECATED {
    display: flex;
    flex-direction: column;
  }

  .fb-file-tile-DEPRECATED .fb-rectangle-16 {
    margin-top: 20px;
    margin-bottom: 20px
  }

  .fb-file-thumbnail {
    background-color: var(--color-bg-secondary);
    aspect-ratio: 16 / 9;
  }

  .fb-border-radius-8 {
    border-radius: 8px;
  }

  .fb-card {
    border: 1px solid var(--color-border);
    border-radius: 13px;
    overflow: hidden;
    display: flex;
    flex-direction: column;
  }

  .fb-file-card-footer {
    border-top: 1px solid var(--color-border);
    padding: 12px 16px;
    display: flex;
    flex-direction: row;
    align-items: center;
    gap: 12px;
  }

  .fb-file-card-footer-text-container {
    display: flex;
    flex-direction: column;
    gap: 2px;
  }

  .fb-project-tile {
    border: 1px solid var(--color-border);
    border-radius: 16px;
    display: flex;
    flex-direction: column;
    padding: 24px;
  }

  .fb-project-tile > :nth-child(2) {
    margin-top: 16px;
  }

  .fb-project-tile > :nth-child(3) {
    margin-top: 8px;
  }

  .fb-team-tile {
    border: 1px solid var(--color-border);
    border-radius: 16px;
    display: flex;
    flex-direction: column;
    padding: 24px;
  }

  .fb-team-tile > :nth-child(2) {
    margin-top: 48px;
  }

  .fb-team-tile > :nth-child(3),
  .fb-team-tile > :nth-child(4) {
    margin-top: 8px;
  }

  .fb-project-preview-grid {
    display: grid;
    gap: 12px;
    justify-items: stretch;
    grid-template-columns: 1fr 1fr;
  }

  @media (max-width: 645px) {

    .fb-tile-grid {
      grid-template-columns: 100%;
    }
  }

  .fb-profile-grid-header {
    margin-top: 24px;
    margin-bottom: 8px;
  }

</style>


      <meta name="mobile-web-app-capable" content="yes">
      <meta name="viewport" content="width=device-width, initial-scale=1.0, maximum-scale=1.0, user-scalable=no">

      <meta name="apple-mobile-web-app-capable" content="yes">
      <meta property="og:title" content="Figma" />
    <meta property="og:site_name" content="Figma" />

    


<link rel="icon" sizes="192x192" href="https://static.figma.com/uploads/1a667ef53b7c4837049399d0593ffca39e0bec9e">
<link rel="icon" sizes="128x128" href="https://static.figma.com/uploads/b6df2735e4cb368306acf5480b50f96e69f96099">

<link rel="icon" type="image/png" href="https://static.figma.com/app/icon/1/favicon.png" />
<!--[if IE]><link rel="shortcut icon" href="https://static.figma.com/app/icon/1/favicon.ico" type="image/vnd.microsoft.icon" /><![endif]-->
<link rel="icon" sizes="any" type="image/svg+xml" href="https://static.figma.com/app/icon/1/favicon.svg">

<link rel="apple-touch-icon" sizes="76x76"   href="https://static.figma.com/app/icon/1/touch-76.png">
<link rel="apple-touch-icon" sizes="120x120" href="https://static.figma.com/app/icon/1/touch-120.png">
<link rel="apple-touch-icon" sizes="152x152" href="https://static.figma.com/app/icon/1/touch-152.png">
<link rel="apple-touch-icon" sizes="167x167" href="https://static.figma.com/app/icon/1/touch-167.png">
<link rel="apple-touch-icon" sizes="180x180" href="https://static.figma.com/app/icon/1/touch-180.png">




        <link rel="preload" href="https:&#47;&#47;static.figma.com&#47;uploads&#47;2cca21a49f7dad1daa612d73d50357644671964a" as="font" crossorigin="anonymous">
        <link rel="preload" href="https:&#47;&#47;static.figma.com&#47;uploads&#47;43d730c59dee2754d29e0d946ba8cb8339656979" as="font" crossorigin="anonymous">
        <link rel="preload" href="https:&#47;&#47;static.figma.com&#47;webfont&#47;1&#47;DSEG7Classic-Italic-Custom2.woff2" as="font" crossorigin="anonymous">

      <link href="https:&#47;&#47;www.figma.com&#47;webpack-artifacts&#47;assets&#47;figma_app-62c6b0d8efd7e5af.min.css.br" rel="stylesheet" crossorigin="anonymous">

      <link rel="preload" as="fetch" id="englishDictionaryUrl" href="https:&#47;&#47;www.figma.com&#47;webpack-artifacts&#47;assets&#47;figma_app-9a68d7bb8dd9c224.min.en.json.br" crossorigin="anonymous" />
      <link rel="preload" as="fetch" id="dictionaryUrl" href="https:&#47;&#47;www.figma.com&#47;i18n-artifacts&#47;locales&#47;3349e5241caca8248452389d74a9caef16a4a031" crossorigin="anonymous" />
      <link rel="preload" as="fetch" id="dbDictionaryUrl" href="https:&#47;&#47;www.figma.com&#47;i18n-artifacts&#47;locales&#47;8d22860464a84e66f61df3d8a3807c49295d569b" crossorigin="anonymous" />
  </head>
  <body class="feature_flag_fpl_select_aria_disabled feature_flag_fpl_a11y_grid feature_flag_plan_level_file_export_controls feature_flag_ds_extended_collections feature_flag_dse_fpl_wave_2 feature_flag_aip_content_fill feature_flag_fpl_split_input feature_flag_dse_fpl_wave_1 feature_flag_fpl_a11y_rotation feature_flag_fpl_submenu_stay_open feature_flag_fpl_menu_under_curator feature_flag_fpl_flash_view_migration feature_flag_bake_chat_message_revamp feature_flag_aip_magnolia feature_flag_qa_user_additional_feedback feature_flag_fpl_dont_soft_dismiss_floating_overlay_clicks feature_flag_fpl_tooltip feature_flag_ds_extended_collections_plankey feature_flag_unified_index_v3_modal_z feature_flag_bake_manual_edits feature_flag_ds_no_auto_min_max_size_override_on_detach feature_flag_aip_content_fill_no_autolayout feature_flag_fpl_a11y_place_image_announcement feature_flag_fpl_cap_window_height_at_full feature_flag_cmty_release_plugin_row_v2 feature_flag_ds_gradient_variables feature_flag_ui3_mixin_changes">


    <div id="react-page"></div>

      <script nonce="8wZUP/bM2tMogCHqp7Om3w==">
  const themePreference = window.localStorage.getItem('global-debug-theme-preference') || 'system'

  let theme
  if (themePreference === 'dark') {
    theme = 'dark'
  } else if (themePreference === 'system') {
    theme = window.matchMedia('(prefers-color-scheme: dark)').matches ? 'dark' : 'light'
  } else {
    theme = 'light'
  }

  document.querySelector("body").dataset.preferredTheme = theme
</script>



      <div class='file-browser-loading-page-container'>
  <div id="filebrowser-loading-page"
      class="fb-page-layout hidden fadeOut"
  >
  <div id="filebrowser-loading-progress-bar"></div>

  <div class="fb-flex-row">
    <div id="filebrowser-loading-sidebar" class="fb-sidebar">
      <div class="fb-sidebar-account-and-notifications">
        <div class="fb-circle-24 fb-shrink-0"></div>
        <div class="fb-rectangle-16 fb-width-120"></div>
      </div>
      <div class="fb-sidebar-searchbar">
        <div class="fb-rectangle-32 fb-width-full"></div>
      </div>
      <div class="fb-sidebar-row">
        <div class="fb-rectangle-16 fb-width-16 fb-shrink-0"></div>
        <div class="fb-rectangle-16 fb-width-70"></div>
      </div>
      <div class="fb-divider"></div>
      <div class="fb-sidebar-row">
        <div class="fb-circle-16"></div>
        <div class="fb-rectangle-16 fb-width-115"></div>
      </div>
      <div class="fb-sidebar-row">
        <div class="fb-rectangle-16 fb-width-16 fb-shrink-0"></div>
        <div class="fb-rectangle-16 fb-width-70"></div>
      </div>
      <div class="fb-sidebar-row">
        <div class="fb-rectangle-16 fb-width-16 fb-shrink-0"></div>
        <div class="fb-rectangle-16 fb-width-100"></div>
      </div>
      <div class="fb-sidebar-row">
        <div class="fb-rectangle-16 fb-width-60"></div>
      </div>
      <div class="fb-sidebar-row">
        <div class="fb-rectangle-16 fb-width-16 fb-shrink-0"></div>
        <div class="fb-rectangle-16 fb-width-100"></div>
      </div>
      <div class="fb-sidebar-row">
        <div class="fb-rectangle-16 fb-width-16 fb-shrink-0"></div>
        <div class="fb-rectangle-16 fb-width-80"></div>
      </div>
      <div class="fb-sidebar-row">
        <div class="fb-rectangle-16 fb-width-16 fb-shrink-0"></div>
        <div class="fb-rectangle-16 fb-width-120"></div>
      </div>
      <div class="fb-sidebar-row">
        <div class="fb-rectangle-16 fb-width-16 fb-shrink-0"></div>
        <div class="fb-rectangle-16 fb-width-105"></div>
      </div>
    </div>


    <div class="fb-page">


          <div class="fb-toolbar-48">
            <div class="fb-rectangle-16 fb-width-120"></div>
          </div>



      <div class="fb-page-content-columns">

        <div class="fb-page-content">

          <div id="loading-content-pane">
            <div class="fb-fading-content">


                  <div class="fb-tile-grid fb-tile-grid-top-padding">

                      <div class="fb-card">
                        <div class="fb-file-thumbnail"></div>
                        <div class="fb-file-card-footer">
                          <div class="fb-rectangle-16 fb-width-16"></div>
                          <div class="fb-file-card-footer-text-container">
                            <div class="fb-rectangle-16 fb-width-120"></div>
                            <div class="fb-rectangle-16 fb-width-88"></div>
                          </div>
                        </div>
                      </div>
                      <div class="fb-card">
                        <div class="fb-file-thumbnail"></div>
                        <div class="fb-file-card-footer">
                          <div class="fb-rectangle-16 fb-width-16"></div>
                          <div class="fb-file-card-footer-text-container">
                            <div class="fb-rectangle-16 fb-width-120"></div>
                            <div class="fb-rectangle-16 fb-width-88"></div>
                          </div>
                        </div>
                      </div>
                      <div class="fb-card">
                        <div class="fb-file-thumbnail"></div>
                        <div class="fb-file-card-footer">
                          <div class="fb-rectangle-16 fb-width-16"></div>
                          <div class="fb-file-card-footer-text-container">
                            <div class="fb-rectangle-16 fb-width-120"></div>
                            <div class="fb-rectangle-16 fb-width-88"></div>
                          </div>
                        </div>
                      </div>
                      <div class="fb-card">
                        <div class="fb-file-thumbnail"></div>
                        <div class="fb-file-card-footer">
                          <div class="fb-rectangle-16 fb-width-16"></div>
                          <div class="fb-file-card-footer-text-container">
                            <div class="fb-rectangle-16 fb-width-120"></div>
                            <div class="fb-rectangle-16 fb-width-88"></div>
                          </div>
                        </div>
                      </div>
                      <div class="fb-card">
                        <div class="fb-file-thumbnail"></div>
                        <div class="fb-file-card-footer">
                          <div class="fb-rectangle-16 fb-width-16"></div>
                          <div class="fb-file-card-footer-text-container">
                            <div class="fb-rectangle-16 fb-width-120"></div>
                            <div class="fb-rectangle-16 fb-width-88"></div>
                          </div>
                        </div>
                      </div>
                      <div class="fb-card">
                        <div class="fb-file-thumbnail"></div>
                        <div class="fb-file-card-footer">
                          <div class="fb-rectangle-16 fb-width-16"></div>
                          <div class="fb-file-card-footer-text-container">
                            <div class="fb-rectangle-16 fb-width-120"></div>
                            <div class="fb-rectangle-16 fb-width-88"></div>
                          </div>
                        </div>
                      </div>
                      <div class="fb-card">
                        <div class="fb-file-thumbnail"></div>
                        <div class="fb-file-card-footer">
                          <div class="fb-rectangle-16 fb-width-16"></div>
                          <div class="fb-file-card-footer-text-container">
                            <div class="fb-rectangle-16 fb-width-120"></div>
                            <div class="fb-rectangle-16 fb-width-88"></div>
                          </div>
                        </div>
                      </div>
                      <div class="fb-card">
                        <div class="fb-file-thumbnail"></div>
                        <div class="fb-file-card-footer">
                          <div class="fb-rectangle-16 fb-width-16"></div>
                          <div class="fb-file-card-footer-text-container">
                            <div class="fb-rectangle-16 fb-width-120"></div>
                            <div class="fb-rectangle-16 fb-width-88"></div>
                          </div>
                        </div>
                      </div>
                      <div class="fb-card">
                        <div class="fb-file-thumbnail"></div>
                        <div class="fb-file-card-footer">
                          <div class="fb-rectangle-16 fb-width-16"></div>
                          <div class="fb-file-card-footer-text-container">
                            <div class="fb-rectangle-16 fb-width-120"></div>
                            <div class="fb-rectangle-16 fb-width-88"></div>
                          </div>
                        </div>
                      </div>
                      <div class="fb-card">
                        <div class="fb-file-thumbnail"></div>
                        <div class="fb-file-card-footer">
                          <div class="fb-rectangle-16 fb-width-16"></div>
                          <div class="fb-file-card-footer-text-container">
                            <div class="fb-rectangle-16 fb-width-120"></div>
                            <div class="fb-rectangle-16 fb-width-88"></div>
                          </div>
                        </div>
                      </div>
                      <div class="fb-card">
                        <div class="fb-file-thumbnail"></div>
                        <div class="fb-file-card-footer">
                          <div class="fb-rectangle-16 fb-width-16"></div>
                          <div class="fb-file-card-footer-text-container">
                            <div class="fb-rectangle-16 fb-width-120"></div>
                            <div class="fb-rectangle-16 fb-width-88"></div>
                          </div>
                        </div>
                      </div>
                      <div class="fb-card">
                        <div class="fb-file-thumbnail"></div>
                        <div class="fb-file-card-footer">
                          <div class="fb-rectangle-16 fb-width-16"></div>
                          <div class="fb-file-card-footer-text-container">
                            <div class="fb-rectangle-16 fb-width-120"></div>
                            <div class="fb-rectangle-16 fb-width-88"></div>
                          </div>
                        </div>
                      </div>
                      <div class="fb-card">
                        <div class="fb-file-thumbnail"></div>
                        <div class="fb-file-card-footer">
                          <div class="fb-rectangle-16 fb-width-16"></div>
                          <div class="fb-file-card-footer-text-container">
                            <div class="fb-rectangle-16 fb-width-120"></div>
                            <div class="fb-rectangle-16 fb-width-88"></div>
                          </div>
                        </div>
                      </div>
                      <div class="fb-card">
                        <div class="fb-file-thumbnail"></div>
                        <div class="fb-file-card-footer">
                          <div class="fb-rectangle-16 fb-width-16"></div>
                          <div class="fb-file-card-footer-text-container">
                            <div class="fb-rectangle-16 fb-width-120"></div>
                            <div class="fb-rectangle-16 fb-width-88"></div>
                          </div>
                        </div>
                      </div>
                      <div class="fb-card">
                        <div class="fb-file-thumbnail"></div>
                        <div class="fb-file-card-footer">
                          <div class="fb-rectangle-16 fb-width-16"></div>
                          <div class="fb-file-card-footer-text-container">
                            <div class="fb-rectangle-16 fb-width-120"></div>
                            <div class="fb-rectangle-16 fb-width-88"></div>
                          </div>
                        </div>
                      </div>
                      <div class="fb-card">
                        <div class="fb-file-thumbnail"></div>
                        <div class="fb-file-card-footer">
                          <div class="fb-rectangle-16 fb-width-16"></div>
                          <div class="fb-file-card-footer-text-container">
                            <div class="fb-rectangle-16 fb-width-120"></div>
                            <div class="fb-rectangle-16 fb-width-88"></div>
                          </div>
                        </div>
                      </div>
                      <div class="fb-card">
                        <div class="fb-file-thumbnail"></div>
                        <div class="fb-file-card-footer">
                          <div class="fb-rectangle-16 fb-width-16"></div>
                          <div class="fb-file-card-footer-text-container">
                            <div class="fb-rectangle-16 fb-width-120"></div>
                            <div class="fb-rectangle-16 fb-width-88"></div>
                          </div>
                        </div>
                      </div>
                      <div class="fb-card">
                        <div class="fb-file-thumbnail"></div>
                        <div class="fb-file-card-footer">
                          <div class="fb-rectangle-16 fb-width-16"></div>
                          <div class="fb-file-card-footer-text-container">
                            <div class="fb-rectangle-16 fb-width-120"></div>
                            <div class="fb-rectangle-16 fb-width-88"></div>
                          </div>
                        </div>
                      </div>
                      <div class="fb-card">
                        <div class="fb-file-thumbnail"></div>
                        <div class="fb-file-card-footer">
                          <div class="fb-rectangle-16 fb-width-16"></div>
                          <div class="fb-file-card-footer-text-container">
                            <div class="fb-rectangle-16 fb-width-120"></div>
                            <div class="fb-rectangle-16 fb-width-88"></div>
                          </div>
                        </div>
                      </div>
                      <div class="fb-card">
                        <div class="fb-file-thumbnail"></div>
                        <div class="fb-file-card-footer">
                          <div class="fb-rectangle-16 fb-width-16"></div>
                          <div class="fb-file-card-footer-text-container">
                            <div class="fb-rectangle-16 fb-width-120"></div>
                            <div class="fb-rectangle-16 fb-width-88"></div>
                          </div>
                        </div>
                      </div>
                      <div class="fb-card">
                        <div class="fb-file-thumbnail"></div>
                        <div class="fb-file-card-footer">
                          <div class="fb-rectangle-16 fb-width-16"></div>
                          <div class="fb-file-card-footer-text-container">
                            <div class="fb-rectangle-16 fb-width-120"></div>
                            <div class="fb-rectangle-16 fb-width-88"></div>
                          </div>
                        </div>
                      </div>
                  </div>

            </div>
          </div>
        </div>

        &nbsp;


      </div>
    </div>
  </div>
</div>




    <script nonce="8wZUP/bM2tMogCHqp7Om3w==" data-entrypoint="figma_app">
      window.ENTRY_POINT = document.currentScript.dataset.entrypoint
    </script>

    

      <script nonce="8wZUP/bM2tMogCHqp7Om3w==">
    window['sentryConfig'] = {
      id: 1611499334421898866,
    }
  </script>

    

      <script nonce="8wZUP/bM2tMogCHqp7Om3w==">performance?.mark('loadTimings:jsEvalStart')</script>
        <script nonce="8wZUP/bM2tMogCHqp7Om3w==" src="https:&#47;&#47;www.figma.com&#47;webpack-artifacts&#47;assets&#47;runtime~figma_app-6654d38182d1a7cd.min.js.br" defer crossorigin="anonymous"></script>
        <script nonce="8wZUP/bM2tMogCHqp7Om3w==" src="https:&#47;&#47;www.figma.com&#47;webpack-artifacts&#47;assets&#47;vendor-core-ade2edecaf4781c7.min.js.br" defer crossorigin="anonymous"></script>
        <script nonce="8wZUP/bM2tMogCHqp7Om3w==" src="https:&#47;&#47;www.figma.com&#47;webpack-artifacts&#47;assets&#47;svg-773ec884034c346e.min.js.br" defer crossorigin="anonymous"></script>
        <script nonce="8wZUP/bM2tMogCHqp7Om3w==" src="https:&#47;&#47;www.figma.com&#47;webpack-artifacts&#47;assets&#47;svg-1243c0722dac1c69.min.js.br" defer crossorigin="anonymous"></script>
        <script nonce="8wZUP/bM2tMogCHqp7Om3w==" src="https:&#47;&#47;www.figma.com&#47;webpack-artifacts&#47;assets&#47;svg-be02c1ffbf0aec0d.min.js.br" defer crossorigin="anonymous"></script>
        <script nonce="8wZUP/bM2tMogCHqp7Om3w==" src="https:&#47;&#47;www.figma.com&#47;webpack-artifacts&#47;assets&#47;svg-8302926740278639.min.js.br" defer crossorigin="anonymous"></script>
        <script nonce="8wZUP/bM2tMogCHqp7Om3w==" src="https:&#47;&#47;www.figma.com&#47;webpack-artifacts&#47;assets&#47;svg-10e6dcec46a9da5b.min.js.br" defer crossorigin="anonymous"></script>
        <script nonce="8wZUP/bM2tMogCHqp7Om3w==" src="https:&#47;&#47;www.figma.com&#47;webpack-artifacts&#47;assets&#47;cssbuilder-4924a9f8a79aa64a.min.js.br" defer crossorigin="anonymous"></script>
        <script nonce="8wZUP/bM2tMogCHqp7Om3w==" src="https:&#47;&#47;www.figma.com&#47;webpack-artifacts&#47;assets&#47;svg-039572250fe3ab4b.min.js.br" defer crossorigin="anonymous"></script>
        <script nonce="8wZUP/bM2tMogCHqp7Om3w==" src="https:&#47;&#47;www.figma.com&#47;webpack-artifacts&#47;assets&#47;svg-e23b98fc45c25527.min.js.br" defer crossorigin="anonymous"></script>
        <script nonce="8wZUP/bM2tMogCHqp7Om3w==" src="https:&#47;&#47;www.figma.com&#47;webpack-artifacts&#47;assets&#47;svg-a337b013ed90d899.min.js.br" defer crossorigin="anonymous"></script>
        <script nonce="8wZUP/bM2tMogCHqp7Om3w==" src="https:&#47;&#47;www.figma.com&#47;webpack-artifacts&#47;assets&#47;svg-2eb127e51a93b20b.min.js.br" defer crossorigin="anonymous"></script>
        <script nonce="8wZUP/bM2tMogCHqp7Om3w==" src="https:&#47;&#47;www.figma.com&#47;webpack-artifacts&#47;assets&#47;vendor-e02619323541de64.min.js.br" defer crossorigin="anonymous"></script>
        <script nonce="8wZUP/bM2tMogCHqp7Om3w==" src="https:&#47;&#47;www.figma.com&#47;webpack-artifacts&#47;assets&#47;vendor-fdcc732e0d2d4c0f.min.js.br" defer crossorigin="anonymous"></script>
        <script nonce="8wZUP/bM2tMogCHqp7Om3w==" src="https:&#47;&#47;www.figma.com&#47;webpack-artifacts&#47;assets&#47;vendor-8113207a091b7299.min.js.br" defer crossorigin="anonymous"></script>
        <script nonce="8wZUP/bM2tMogCHqp7Om3w==" src="https:&#47;&#47;www.figma.com&#47;webpack-artifacts&#47;assets&#47;vendor-61558bc8fb46456d.min.js.br" defer crossorigin="anonymous"></script>
        <script nonce="8wZUP/bM2tMogCHqp7Om3w==" src="https:&#47;&#47;www.figma.com&#47;webpack-artifacts&#47;assets&#47;vendor-5fdbd10ea5780ca3.min.js.br" defer crossorigin="anonymous"></script>
        <script nonce="8wZUP/bM2tMogCHqp7Om3w==" src="https:&#47;&#47;www.figma.com&#47;webpack-artifacts&#47;assets&#47;6691-ea1a3b4571a0f448.min.js.br" defer crossorigin="anonymous"></script>
        <script nonce="8wZUP/bM2tMogCHqp7Om3w==" src="https:&#47;&#47;www.figma.com&#47;webpack-artifacts&#47;assets&#47;406-656fac6d09c8fbc1.min.js.br" defer crossorigin="anonymous"></script>
        <script nonce="8wZUP/bM2tMogCHqp7Om3w==" src="https:&#47;&#47;www.figma.com&#47;webpack-artifacts&#47;assets&#47;5340-ca907fbcb950ef0b.min.js.br" defer crossorigin="anonymous"></script>
        <script nonce="8wZUP/bM2tMogCHqp7Om3w==" src="https:&#47;&#47;www.figma.com&#47;webpack-artifacts&#47;assets&#47;856-de3d583022ec61b8.min.js.br" defer crossorigin="anonymous"></script>
        <script nonce="8wZUP/bM2tMogCHqp7Om3w==" src="https:&#47;&#47;www.figma.com&#47;webpack-artifacts&#47;assets&#47;8222-714b50f6fa462b79.min.js.br" defer crossorigin="anonymous"></script>
        <script nonce="8wZUP/bM2tMogCHqp7Om3w==" src="https:&#47;&#47;www.figma.com&#47;webpack-artifacts&#47;assets&#47;2179-5c54f42e41f9e61d.min.js.br" defer crossorigin="anonymous"></script>
        <script nonce="8wZUP/bM2tMogCHqp7Om3w==" src="https:&#47;&#47;www.figma.com&#47;webpack-artifacts&#47;assets&#47;2438-a12b02b1f2114927.min.js.br" defer crossorigin="anonymous"></script>
        <script nonce="8wZUP/bM2tMogCHqp7Om3w==" src="https:&#47;&#47;www.figma.com&#47;webpack-artifacts&#47;assets&#47;8821-ffaa9436357e524e.min.js.br" defer crossorigin="anonymous"></script>
        <script nonce="8wZUP/bM2tMogCHqp7Om3w==" src="https:&#47;&#47;www.figma.com&#47;webpack-artifacts&#47;assets&#47;1165-0359555f5767163f.min.js.br" defer crossorigin="anonymous"></script>
        <script nonce="8wZUP/bM2tMogCHqp7Om3w==" src="https:&#47;&#47;www.figma.com&#47;webpack-artifacts&#47;assets&#47;1379-7435cf66a2de8919.min.js.br" defer crossorigin="anonymous"></script>
        <script nonce="8wZUP/bM2tMogCHqp7Om3w==" src="https:&#47;&#47;www.figma.com&#47;webpack-artifacts&#47;assets&#47;7554-adace7f193e1e91a.min.js.br" defer crossorigin="anonymous"></script>
        <script nonce="8wZUP/bM2tMogCHqp7Om3w==" src="https:&#47;&#47;www.figma.com&#47;webpack-artifacts&#47;assets&#47;1772-f0a11585c70c1cf5.min.js.br" defer crossorigin="anonymous"></script>
        <script nonce="8wZUP/bM2tMogCHqp7Om3w==" src="https:&#47;&#47;www.figma.com&#47;webpack-artifacts&#47;assets&#47;8804-b1e42bf9ef0b389d.min.js.br" defer crossorigin="anonymous"></script>
        <script nonce="8wZUP/bM2tMogCHqp7Om3w==" src="https:&#47;&#47;www.figma.com&#47;webpack-artifacts&#47;assets&#47;figma_app-b0caec42b9db6be5.min.js.br" defer crossorigin="anonymous"></script>
    <script nonce="8wZUP/bM2tMogCHqp7Om3w==">
      document.addEventListener('DOMContentLoaded', (e) => {
        performance?.mark('loadTimings:DCL', { startTime: e.timeStamp })
      })
      window.addEventListener('load', (e) => {
        performance?.mark('loadTimings:LOAD', { startTime: e.timeStamp })
      })
    </script>
  </body>
</html>
