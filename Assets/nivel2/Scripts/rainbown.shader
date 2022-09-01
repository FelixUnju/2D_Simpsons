// Upgrade NOTE: replaced 'mul(UNITY_MATRIX_MVP,*)' with 'UnityObjectToClipPos(*)'

Shader "Custom/TexturedTextWithColor" {
    Properties{
        _MainTex("Font Texture (Alpha A)", 2D) = "white" {}
        _OverlayTex("Overlay Texture (RGB)", 2D) = "white" {}
        _Color("Text Color", Color) = (1,1,1,1)
        _WrapFactor("Wrap Amount", float) = 1
    }

        SubShader{

            LOD 200
            Tags {
                "Queue" = "Transparent"
                "IgnoreProjector" = "True"
                "RenderType" = "Transparent"
                "PreviewType" = "Plane"
            //"ForceSupported" = "True"
        }
        Lighting Off Cull Off ZTest[unity_GUIZTestMode] ZWrite Off Fog { Mode Off }
            //Offset -1, -1
            Blend SrcAlpha OneMinusSrcAlpha

            Pass {
                CGPROGRAM
                // Upgrade NOTE: excluded shader from DX11 and Xbox360; has structs without semantics (struct v2f members scrPos)
                #pragma exclude_renderers d3d11 xbox360
                            #pragma vertex vert
                            #pragma fragment frag

                            #include "UnityCG.cginc"

                            struct appdata_t {
                                float4 vertex : POSITION;
                                fixed4 color : COLOR;
                                float2 texcoord : TEXCOORD0;
                            };

                            struct v2f {
                                float4 vertex : POSITION;
                                fixed4 color : COLOR;
                                float2 texcoord : TEXCOORD0;
                                float4 scrPos;
                            };

                            sampler2D _MainTex;
                            uniform float4 _MainTex_ST;
                            uniform fixed4 _Color;
                            sampler2D _OverlayTex;
                            uniform float _WrapFactor;

                            v2f vert(appdata_t v)
                            {
                                v2f o;
                                o.vertex = UnityObjectToClipPos(v.vertex);
                                o.color = v.color * _Color;
                                o.texcoord = TRANSFORM_TEX(v.texcoord,_MainTex);
                                o.scrPos = ComputeScreenPos(o.vertex);
                                return o;
                            }

                            half4 frag(v2f i) : COLOR
                            {
                                half4 col = i.color;
                                float2 swap;

                                swap.xy = _WrapFactor * i.scrPos.xy;
                                swap.y += swap.x;

                                col.rgb *= tex2D(_OverlayTex, swap).rgb;
                                col.a *= tex2D(_MainTex, i.texcoord).a;
                                //clip (col.a - 0.01);
                                return col;
                            }
                            ENDCG
                        }
        }
}
