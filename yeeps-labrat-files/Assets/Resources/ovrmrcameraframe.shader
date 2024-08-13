Shader "Oculus/OVRMRCameraFrame" {
	Properties {
		_Color ("Main Color", Vector) = (1,1,1,1)
		_MainTex ("Main Texture", 2D) = "white" {}
		_Visible ("Visible", Range(0, 1)) = 1
		_ChromaAlphaCutoff ("ChromaAlphaCutoff", Range(0, 1)) = 0.01
		_ChromaToleranceA ("ChromaToleranceA", Range(0, 50)) = 20
		_ChromaToleranceB ("ChromaToleranceB", Range(0, 50)) = 15
		_ChromaShadows ("ChromaShadows", Range(0, 1)) = 0.02
	}
	//DummyShaderTextExporter
	SubShader{
		Tags { "RenderType"="Opaque" }
		LOD 200
		CGPROGRAM
#pragma surface surf Standard
#pragma target 3.0

		sampler2D _MainTex;
		fixed4 _Color;
		struct Input
		{
			float2 uv_MainTex;
		};
		
		void surf(Input IN, inout SurfaceOutputStandard o)
		{
			fixed4 c = tex2D(_MainTex, IN.uv_MainTex) * _Color;
			o.Albedo = c.rgb;
			o.Alpha = c.a;
		}
		ENDCG
	}
}