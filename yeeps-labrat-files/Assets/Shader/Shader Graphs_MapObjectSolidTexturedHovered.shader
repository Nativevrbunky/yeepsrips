Shader "Shader Graphs/MapObjectSolidTexturedHovered" {
	Properties {
		_Color ("Color", Vector) = (0.3021093,0.8773585,0.4849463,1)
		_BrightnessBoost ("BrightnessBoost", Float) = 0
		_Smoothness ("Smoothness", Float) = 0
		[NoScaleOffset] _MainTex ("MainTex", 2D) = "white" {}
		_HoverPointRight ("HoverPointRight", Vector) = (0,0,0,0)
		_HoverPointLeft ("HoverPointLeft", Vector) = (0,0,0,0)
		_HoverBrightnessBoost ("HoverBrightnessBoost", Float) = 0.4
		[Toggle(TRIPLANAR)] TRIPLANAR ("TRIPLANAR", Float) = 0
		[HDR] _Emission ("Emission", Vector) = (0,0,0,0)
		[Toggle(SCROLLING)] SCROLLING ("SCROLLING", Float) = 0
		_TextureBoost ("TextureBoost", Float) = 0
		[HideInInspector] _QueueOffset ("_QueueOffset", Float) = 0
		[HideInInspector] _QueueControl ("_QueueControl", Float) = -1
		[HideInInspector] [NoScaleOffset] unity_Lightmaps ("unity_Lightmaps", 2DArray) = "" {}
		[HideInInspector] [NoScaleOffset] unity_LightmapsInd ("unity_LightmapsInd", 2DArray) = "" {}
		[HideInInspector] [NoScaleOffset] unity_ShadowMasks ("unity_ShadowMasks", 2DArray) = "" {}
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
	Fallback "Hidden/Shader Graph/FallbackError"
	//CustomEditor "UnityEditor.ShaderGraph.GenericShaderGraphMaterialGUI"
}