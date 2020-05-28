Shader "Custom/Color"{
    Properties{
        _Color("Light Color",Color)=(1,1,1,1)
        _Dir("Light Dir",Vector)=(0,0,1,0)
        _Intensity("Intensity",float)=1.0
    }
    SubShader{
        Tags{"RenderType"="Opaque"}
        LOD 100
        Pass{
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #include "UnityCG.cginc"

            struct v2f{
                float4 vertex : POSITION;
                float3 normal : NORMAL;
            }
            fixed4 _Color;
            fixed4 _Dir;
            float _Intensity;

            v2f vert(appdata_base v){
                v2f o;
                o.vertex=UnityObjectToClipPos(v.vertex);
                o.normal=v.normal;
                return o;
            }
            fixed frag(v2f i):COLOR{
                fixed3 dir=fixed3(-_Dir.x,-_Dir.y,-_Dir.z);
                dir=normalize(dir);
                fixed3 nrm=normalize(i.normal);
                float bis=dot(dir,nrm);
                if(bis<=0){
                    bis=0;

                }
                fixed col=_Color*bis*_Intensity;
                return col;
            }
            ENDCG
        }

    }

}