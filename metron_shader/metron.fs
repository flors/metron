/*{
    "CREDIT": "Metron",
    "DESCRIPTION": "describe your material here",
    "TAGS": "graphic",
    "VSN": "1.0",
    "INPUTS": [ 
	  
        { "LABEL": "Size", "NAME": "size", "TYPE": "float", "MIN": 0.0, "MAX": 1.0, "DEFAULT": 1 },
       
	   	{ "LABEL": "LEDS_1/L1_out_L", "NAME": "L1_OUT_L", "TYPE": "float", "MIN":  0.0, "MAX":  1.0, "DEFAULT": 0},
       	{ "LABEL": "LEDS_1/L1_IN", "NAME": "L1_IN", "TYPE": "float", "MIN":  0.0, "MAX":  1.0, "DEFAULT": 0},
		{ "LABEL": "LEDS_1/L1_out_R", "NAME": "L1_OUT_R", "TYPE": "float", "MIN":  0.0, "MAX":  1.0, "DEFAULT": 0},
		
		{ "LABEL": "LEDS_2/L2_out_L", "NAME": "L2_OUT_L", "TYPE": "float", "MIN":  0.0, "MAX":  1.0, "DEFAULT": 0},
		{ "LABEL": "LEDS_2/L2_IN", "NAME": "L2_IN", "TYPE": "float", "MIN":  0.0, "MAX":  1.0, "DEFAULT": 0},
		{ "LABEL": "LEDS_2/L2_out_R", "NAME": "L2_OUT_R", "TYPE": "float", "MIN":  0.0, "MAX":  1.0, "DEFAULT": 0},
		
		{ "LABEL": "LEDS_3/L3_out_L", "NAME": "L3_OUT_L", "TYPE": "float", "MIN":  0.0, "MAX":  1.0, "DEFAULT": 0},
		{ "LABEL": "LEDS_3/L3_IN", "NAME": "L3_IN", "TYPE": "float", "MIN":  0.0, "MAX":  1.0, "DEFAULT": 0},
		{ "LABEL": "LEDS_3/L3_out_R", "NAME": "L3_OUT_R", "TYPE": "float", "MIN":  0.0, "MAX":  1.0, "DEFAULT": 0},
		
		{ "LABEL": "LEDS_4/L4_out_L", "NAME": "L4_OUT_L", "TYPE": "float", "MIN":  0.0, "MAX":  1.0, "DEFAULT": 0},
		{ "LABEL": "LEDS_4/L4_IN", "NAME": "L4_IN", "TYPE": "float", "MIN":  0.0, "MAX":  1.0, "DEFAULT": 0},
		{ "LABEL": "LEDS_4/L4_out_R", "NAME": "L4_OUT_R", "TYPE": "float", "MIN":  0.0, "MAX":  1.0, "DEFAULT": 0},
		
		{ "LABEL": "LEDS_5/L5_out_L", "NAME": "L5_OUT_L", "TYPE": "float", "MIN":  0.0, "MAX":  1.0, "DEFAULT": 0},
		{ "LABEL": "LEDS_5/L5_IN", "NAME": "L5_IN", "TYPE": "float", "MIN":  0.0, "MAX":  1.0, "DEFAULT": 0},
		{ "LABEL": "LEDS_5/L5_out_R", "NAME": "L5_OUT_R", "TYPE": "float", "MIN":  0.0, "MAX":  1.0, "DEFAULT": 0},
		
		{ "LABEL": "LEDS_6/L6_out_L", "NAME": "L6_OUT_L", "TYPE": "float", "MIN":  0.0, "MAX":  1.0, "DEFAULT": 0},
		{ "LABEL": "LEDS_6/L6_IN", "NAME": "L6_IN", "TYPE": "float", "MIN":  0.0, "MAX":  1.0, "DEFAULT": 0},
		{ "LABEL": "LEDS_6/L6_out_R", "NAME": "L6_OUT_R", "TYPE": "float", "MIN":  0.0, "MAX":  1.0, "DEFAULT": 0},
		
		{ "LABEL": "LEDS_7/L7_out_L", "NAME": "L7_OUT_L", "TYPE": "float", "MIN":  0.0, "MAX":  1.0, "DEFAULT": 0},
       	{ "LABEL": "LEDS_7/L7_IN", "NAME": "L7_IN", "TYPE": "float", "MIN":  0.0, "MAX":  1.0, "DEFAULT": 0},
		{ "LABEL": "LEDS_7/L7_out_R", "NAME": "L7_OUT_R", "TYPE": "float", "MIN":  0.0, "MAX":  1.0, "DEFAULT": 0},
		
		{ "LABEL": "LEDS_8/L8_out_L", "NAME": "L8_OUT_L", "TYPE": "float", "MIN":  0.0, "MAX":  1.0, "DEFAULT": 0},
		{ "LABEL": "LEDS_8/L8_IN", "NAME": "L8_IN", "TYPE": "float", "MIN":  0.0, "MAX":  1.0, "DEFAULT": 0},
		{ "LABEL": "LEDS_8/L8_out_R", "NAME": "L8_OUT_R", "TYPE": "float", "MIN":  0.0, "MAX":  1.0, "DEFAULT": 0},
		
		{ "LABEL": "LEDS_9/L9_out_L", "NAME": "L9_OUT_L", "TYPE": "float", "MIN":  0.0, "MAX":  1.0, "DEFAULT": 0},
		{ "LABEL": "LEDS_9/L9_IN", "NAME": "L9_IN", "TYPE": "float", "MIN":  0.0, "MAX":  1.0, "DEFAULT": 0},
		{ "LABEL": "LEDS_9/L9_out_R", "NAME": "L9_OUT_R", "TYPE": "float", "MIN":  0.0, "MAX":  1.0, "DEFAULT": 0},
		
		{ "LABEL": "LEDS_10/L10_out_L", "NAME": "L10_OUT_L", "TYPE": "float", "MIN":  0.0, "MAX":  1.0, "DEFAULT": 0},
		{ "LABEL": "LEDS_10/L10_IN", "NAME": "L10_IN", "TYPE": "float", "MIN":  0.0, "MAX":  1.0, "DEFAULT": 0},
		{ "LABEL": "LEDS_10/L10_out_R", "NAME": "L10_OUT_R", "TYPE": "float", "MIN":  0.0, "MAX":  1.0, "DEFAULT": 0},
		
		{ "LABEL": "LEDS_11/L11_out_L", "NAME": "L11_OUT_L", "TYPE": "float", "MIN":  0.0, "MAX":  1.0, "DEFAULT": 0},
		{ "LABEL": "LEDS_11/L11_IN", "NAME": "L11_IN", "TYPE": "float", "MIN":  0.0, "MAX":  1.0, "DEFAULT": 0},
		{ "LABEL": "LEDS_11/L11_out_R", "NAME": "L11_OUT_R", "TYPE": "float", "MIN":  0.0, "MAX":  1.0, "DEFAULT": 0},
		
		{ "LABEL": "LEDS_12/L12_out_L", "NAME": "L12_OUT_L", "TYPE": "float", "MIN":  0.0, "MAX":  1.0, "DEFAULT": 0},
		{ "LABEL": "LEDS_12/L12_IN", "NAME": "L12_IN", "TYPE": "float", "MIN":  0.0, "MAX":  1.0, "DEFAULT": 0},
		{ "LABEL": "LEDS_12/L12_out_R", "NAME": "L12_OUT_R", "TYPE": "float", "MIN":  0.0, "MAX":  1.0, "DEFAULT": 0},

		{ "LABEL": "LEDS_13/L13_out_L", "NAME": "L13_OUT_L", "TYPE": "float", "MIN":  0.0, "MAX":  1.0, "DEFAULT": 0},
		{ "LABEL": "LEDS_13/L13_IN",    "NAME": "L13_IN", "TYPE": "float", "MIN":  0.0, "MAX":  1.0, "DEFAULT": 0},
		{ "LABEL": "LEDS_13/L13_out_R", "NAME": "L13_OUT_R", "TYPE": "float", "MIN":  0.0, "MAX":  1.0, "DEFAULT": 0},

		{ "LABEL": "LEDS_14/L14_out_L", "NAME": "L14_OUT_L", "TYPE": "float", "MIN":  0.0, "MAX":  1.0, "DEFAULT": 0},
		{ "LABEL": "LEDS_14/L14_IN",    "NAME": "L14_IN", "TYPE": "float", "MIN":  0.0, "MAX":  1.0, "DEFAULT": 0},
		{ "LABEL": "LEDS_14/L14_out_R", "NAME": "L14_OUT_R", "TYPE": "float", "MIN":  0.0, "MAX":  1.0, "DEFAULT": 0},

		{ "LABEL": "LEDS_15/L15_out_L", "NAME": "L15_OUT_L", "TYPE": "float", "MIN":  0.0, "MAX":  1.0, "DEFAULT": 0},
		{ "LABEL": "LEDS_15/L15_IN",    "NAME": "L15_IN", "TYPE": "float", "MIN":  0.0, "MAX":  1.0, "DEFAULT": 0},
		{ "LABEL": "LEDS_15/L15_out_R", "NAME": "L15_OUT_R", "TYPE": "float", "MIN":  0.0, "MAX":  1.0, "DEFAULT": 0},

		{ "LABEL": "LEDS_16/L16_out_L", "NAME": "L16_OUT_L", "TYPE": "float", "MIN":  0.0, "MAX":  1.0, "DEFAULT": 0},
		{ "LABEL": "LEDS_16/L16_IN",    "NAME": "L16_IN", "TYPE": "float", "MIN":  0.0, "MAX":  1.0, "DEFAULT": 0},
		{ "LABEL": "LEDS_16/L16_out_R", "NAME": "L16_OUT_R", "TYPE": "float", "MIN":  0.0, "MAX":  1.0, "DEFAULT": 0},

		{ "LABEL": "LEDS_17/L17_out_L", "NAME": "L17_OUT_L", "TYPE": "float", "MIN":  0.0, "MAX":  1.0, "DEFAULT": 0},
		{ "LABEL": "LEDS_17/L17_IN",    "NAME": "L17_IN", "TYPE": "float", "MIN":  0.0, "MAX":  1.0, "DEFAULT": 0},
		{ "LABEL": "LEDS_17/L17_out_R", "NAME": "L17_OUT_R", "TYPE": "float", "MIN":  0.0, "MAX":  1.0, "DEFAULT": 0},

		{ "LABEL": "LEDS_18/L18_out_L", "NAME": "L18_OUT_L", "TYPE": "float", "MIN":  0.0, "MAX":  1.0, "DEFAULT": 0},
		{ "LABEL": "LEDS_18/L18_IN",    "NAME": "L18_IN", "TYPE": "float", "MIN":  0.0, "MAX":  1.0, "DEFAULT": 0},
		{ "LABEL": "LEDS_18/L18_out_R", "NAME": "L18_OUT_R", "TYPE": "float", "MIN":  0.0, "MAX":  1.0, "DEFAULT": 0},

		{ "LABEL": "LEDS_19/L19_out_L", "NAME": "L19_OUT_L", "TYPE": "float", "MIN":  0.0, "MAX":  1.0, "DEFAULT": 0},
		{ "LABEL": "LEDS_19/L19_IN",    "NAME": "L19_IN", "TYPE": "float", "MIN":  0.0, "MAX":  1.0, "DEFAULT": 0},
		{ "LABEL": "LEDS_19/L19_out_R", "NAME": "L19_OUT_R", "TYPE": "float", "MIN":  0.0, "MAX":  1.0, "DEFAULT": 0},

		{ "LABEL": "LEDS_20/L20_out_L", "NAME": "L20_OUT_L", "TYPE": "float", "MIN":  0.0, "MAX":  1.0, "DEFAULT": 0},
		{ "LABEL": "LEDS_20/L20_IN",    "NAME": "L20_IN", "TYPE": "float", "MIN":  0.0, "MAX":  1.0, "DEFAULT": 0},
		{ "LABEL": "LEDS_20/L20_out_R", "NAME": "L20_OUT_R", "TYPE": "float", "MIN":  0.0, "MAX":  1.0, "DEFAULT": 0},

		{ "LABEL": "LEDS_21/L21_out_L", "NAME": "L21_OUT_L", "TYPE": "float", "MIN":  0.0, "MAX":  1.0, "DEFAULT": 0},
		{ "LABEL": "LEDS_21/L21_IN",    "NAME": "L21_IN", "TYPE": "float", "MIN":  0.0, "MAX":  1.0, "DEFAULT": 0},
		{ "LABEL": "LEDS_21/L21_out_R", "NAME": "L21_OUT_R", "TYPE": "float", "MIN":  0.0, "MAX":  1.0, "DEFAULT": 0},

		{ "LABEL": "LEDS_22/L22_out_L", "NAME": "L22_OUT_L", "TYPE": "float", "MIN":  0.0, "MAX":  1.0, "DEFAULT": 0},
		{ "LABEL": "LEDS_22/L22_IN",    "NAME": "L22_IN", "TYPE": "float", "MIN":  0.0, "MAX":  1.0, "DEFAULT": 0},
		{ "LABEL": "LEDS_22/L22_out_R", "NAME": "L22_OUT_R", "TYPE": "float", "MIN":  0.0, "MAX":  1.0, "DEFAULT": 0},

		{ "LABEL": "LEDS_23/L23_out_L", "NAME": "L23_OUT_L", "TYPE": "float", "MIN":  0.0, "MAX":  1.0, "DEFAULT": 0},
		{ "LABEL": "LEDS_23/L23_IN",    "NAME": "L23_IN", "TYPE": "float", "MIN":  0.0, "MAX":  1.0, "DEFAULT": 0},
		{ "LABEL": "LEDS_23/L23_out_R", "NAME": "L23_OUT_R", "TYPE": "float", "MIN":  0.0, "MAX":  1.0, "DEFAULT": 0},

		{ "LABEL": "LEDS_24/L24_out_L", "NAME": "L24_OUT_L", "TYPE": "float", "MIN":  0.0, "MAX":  1.0, "DEFAULT": 0},
		{ "LABEL": "LEDS_24/L24_IN",    "NAME": "L24_IN", "TYPE": "float", "MIN":  0.0, "MAX":  1.0, "DEFAULT": 0},
		{ "LABEL": "LEDS_24/L24_out_R", "NAME": "L24_OUT_R", "TYPE": "float", "MIN":  0.0, "MAX":  1.0, "DEFAULT": 0},

		{ "LABEL": "LEDS_25/L25_out_L", "NAME": "L25_OUT_L", "TYPE": "float", "MIN":  0.0, "MAX":  1.0, "DEFAULT": 0},
		{ "LABEL": "LEDS_25/L25_IN",    "NAME": "L25_IN", "TYPE": "float", "MIN":  0.0, "MAX":  1.0, "DEFAULT": 0},
		{ "LABEL": "LEDS_25/L25_out_R", "NAME": "L25_OUT_R", "TYPE": "float", "MIN":  0.0, "MAX":  1.0, "DEFAULT": 0},

		{ "LABEL": "LEDS_26/L26_out_L", "NAME": "L26_OUT_L", "TYPE": "float", "MIN":  0.0, "MAX":  1.0, "DEFAULT": 0},
		{ "LABEL": "LEDS_26/L26_IN",    "NAME": "L26_IN", "TYPE": "float", "MIN":  0.0, "MAX":  1.0, "DEFAULT": 0},
		{ "LABEL": "LEDS_26/L26_out_R", "NAME": "L26_OUT_R", "TYPE": "float", "MIN":  0.0, "MAX":  1.0, "DEFAULT": 0},

		{ "LABEL": "LEDS_27/L27_out_L", "NAME": "L27_OUT_L", "TYPE": "float", "MIN":  0.0, "MAX":  1.0, "DEFAULT": 0},
		{ "LABEL": "LEDS_27/L27_IN",    "NAME": "L27_IN", "TYPE": "float", "MIN":  0.0, "MAX":  1.0, "DEFAULT": 0},
		{ "LABEL": "LEDS_27/L27_out_R", "NAME": "L27_OUT_R", "TYPE": "float", "MIN":  0.0, "MAX":  1.0, "DEFAULT": 0},

		{ "LABEL": "LEDS_28/L18_out_L", "NAME": "L28_OUT_L", "TYPE": "float", "MIN":  0.0, "MAX":  1.0, "DEFAULT": 0},
		{ "LABEL": "LEDS_28/L18_IN",    "NAME": "L28_IN", "TYPE": "float", "MIN":  0.0, "MAX":  1.0, "DEFAULT": 0},
		{ "LABEL": "LEDS_28/L18_out_R", "NAME": "L28_OUT_R", "TYPE": "float", "MIN":  0.0, "MAX":  1.0, "DEFAULT": 0},

		{ "LABEL": "LEDS_29/L29_out_L", "NAME": "L29_OUT_L", "TYPE": "float", "MIN":  0.0, "MAX":  1.0, "DEFAULT": 0},
		{ "LABEL": "LEDS_29/L29_IN",    "NAME": "L29_IN", "TYPE": "float", "MIN":  0.0, "MAX":  1.0, "DEFAULT": 0},
		{ "LABEL": "LEDS_29/L29_out_R", "NAME": "L29_OUT_R", "TYPE": "float", "MIN":  0.0, "MAX":  1.0, "DEFAULT": 0},

		{ "LABEL": "LEDS_30/L30_out_L", "NAME": "L30_OUT_L", "TYPE": "float", "MIN":  0.0, "MAX":  1.0, "DEFAULT": 0},
		{ "LABEL": "LEDS_30/L30_IN",    "NAME": "L30_IN", "TYPE": "float", "MIN":  0.0, "MAX":  1.0, "DEFAULT": 0},
		{ "LABEL": "LEDS_30/L30_out_R", "NAME": "L30_OUT_R", "TYPE": "float", "MIN":  0.0, "MAX":  1.0, "DEFAULT": 0},

		{ "LABEL": "LEDS_31/L31_out_L", "NAME": "L31_OUT_L", "TYPE": "float", "MIN":  0.0, "MAX":  1.0, "DEFAULT": 0},
		{ "LABEL": "LEDS_31/L31_IN",    "NAME": "L31_IN", "TYPE": "float", "MIN":  0.0, "MAX":  1.0, "DEFAULT": 0},
		{ "LABEL": "LEDS_31/L31_out_R", "NAME": "L31_OUT_R", "TYPE": "float", "MIN":  0.0, "MAX":  1.0, "DEFAULT": 0},

		{ "LABEL": "LEDS_32/L32_out_L", "NAME": "L32_OUT_L", "TYPE": "float", "MIN":  0.0, "MAX":  1.0, "DEFAULT": 0},
		{ "LABEL": "LEDS_32/L32_IN",    "NAME": "L32_IN", "TYPE": "float", "MIN":  0.0, "MAX":  1.0, "DEFAULT": 0},
		{ "LABEL": "LEDS_32/L32_out_R", "NAME": "L32_OUT_R", "TYPE": "float", "MIN":  0.0, "MAX":  1.0, "DEFAULT": 0},

		{ "LABEL": "LEDS_33/L33_out_L", "NAME": "L33_OUT_L", "TYPE": "float", "MIN":  0.0, "MAX":  1.0, "DEFAULT": 0},
		{ "LABEL": "LEDS_33/L33_IN",    "NAME": "L33_IN", "TYPE": "float", "MIN":  0.0, "MAX":  1.0, "DEFAULT": 0},
		{ "LABEL": "LEDS_33/L33_out_R", "NAME": "L33_OUT_R", "TYPE": "float", "MIN":  0.0, "MAX":  1.0, "DEFAULT": 0},

		{ "LABEL": "LEDS_34/L34_out_L", "NAME": "L34_OUT_L", "TYPE": "float", "MIN":  0.0, "MAX":  1.0, "DEFAULT": 0},
		{ "LABEL": "LEDS_34/L34_IN",    "NAME": "L34_IN", "TYPE": "float", "MIN":  0.0, "MAX":  1.0, "DEFAULT": 0},
		{ "LABEL": "LEDS_34/L34_out_R", "NAME": "L34_OUT_R", "TYPE": "float", "MIN":  0.0, "MAX":  1.0, "DEFAULT": 0},

		{ "LABEL": "LEDS_35/L35_out_L", "NAME": "L35_OUT_L", "TYPE": "float", "MIN":  0.0, "MAX":  1.0, "DEFAULT": 0},
		{ "LABEL": "LEDS_35/L35_IN",    "NAME": "L35_IN", "TYPE": "float", "MIN":  0.0, "MAX":  1.0, "DEFAULT": 0},
		{ "LABEL": "LEDS_35/L35_out_R", "NAME": "L35_OUT_R", "TYPE": "float", "MIN":  0.0, "MAX":  1.0, "DEFAULT": 0},

		{ "LABEL": "LEDS_36/L36_out_L", "NAME": "L36_OUT_L", "TYPE": "float", "MIN":  0.0, "MAX":  1.0, "DEFAULT": 0},
		{ "LABEL": "LEDS_36/L36_IN",    "NAME": "L36_IN", "TYPE": "float", "MIN":  0.0, "MAX":  1.0, "DEFAULT": 0},
		{ "LABEL": "LEDS_36/L36_out_R", "NAME": "L36_OUT_R", "TYPE": "float", "MIN":  0.0, "MAX":  1.0, "DEFAULT": 0},

		{ "LABEL": "LEDS_37/L37_out_L", "NAME": "L37_OUT_L", "TYPE": "float", "MIN":  0.0, "MAX":  1.0, "DEFAULT": 0},
		{ "LABEL": "LEDS_37/L37_IN",    "NAME": "L37_IN", "TYPE": "float", "MIN":  0.0, "MAX":  1.0, "DEFAULT": 0},
		{ "LABEL": "LEDS_37/L37_out_R", "NAME": "L37_OUT_R", "TYPE": "float", "MIN":  0.0, "MAX":  1.0, "DEFAULT": 0},

		{ "LABEL": "LEDS_38/L38_out_L", "NAME": "L38_OUT_L", "TYPE": "float", "MIN":  0.0, "MAX":  1.0, "DEFAULT": 0},
		{ "LABEL": "LEDS_38/L38_IN",    "NAME": "L38_IN", "TYPE": "float", "MIN":  0.0, "MAX":  1.0, "DEFAULT": 0},
		{ "LABEL": "LEDS_38/L38_out_R", "NAME": "L38_OUT_R", "TYPE": "float", "MIN":  0.0, "MAX":  1.0, "DEFAULT": 0},
	   
	   
	   
	   
   
        { "LABEL": "AnimLuma/Shape", "NAME": "animshape_luma", "TYPE": "long", "VALUES": ["Out","In","Smooth","Cut"], "DEFAULT": "Smooth", "FLAGS": "generate_as_define" },
        { "LABEL": "AnimLuma/Random Off.", "NAME": "random_offset_luma", "TYPE": "bool", "DEFAULT": false, "FLAGS": "button" },

        { "Label": "Color/Back Color", "NAME": "backgroundColor", "TYPE": "color", "DEFAULT": [ 0.0, 0.0, 0.0, 1.0 ] },  
        { "Label": "Color/Front Color", "NAME": "foregroundColor", "TYPE": "color", "DEFAULT": [ 1.0, 1.0, 1.0, 1.0 ] },
        { "LABEL": "Color/Brightness", "NAME": "brightness", "TYPE": "float", "MIN" : 0.0, "MAX" : 1.0, "DEFAULT": 1.0 },
      ],
	
}*/

#include "MadCommon.glsl"
#include "MadNoise.glsl"
#include "MadSDF.glsl"	
	



vec4 materialColorForPixel( vec2 texCoord )
{
    vec2 cellId;
    vec2 p          = texCoord;
   // vec2 cellSize   = vec2( 1.0 / cells_x, 1.0 / cells_y );
	vec2 cellSize   = vec2( 1.0 / 45, 1.0 / 3 );
    p               = repeat( p, cellSize, cellId );

    vec2 radius = cellSize * 0.5;
	float alpha = 0.0;
	
		
	//Caja1
	if(cellId.y == 0 && cellId.x == 0){
			alpha =  L1_OUT_L;
	}
	
	if(cellId.y == 0 && cellId.x == 1){
			alpha =  L1_IN;
	}
	
	if(cellId.y == 0 && cellId.x == 2){
			alpha =  L1_OUT_R;
	}
	
	//caja 2
	if(cellId.y == 0 && cellId.x == 3){
			alpha =  L2_OUT_L;
	}
	if(cellId.y == 0 && cellId.x == 4){
			alpha =  L2_IN;
	}
	if(cellId.y == 0 && cellId.x == 5){
			alpha =  L2_OUT_R;
	}
	
	//caja 3
	if(cellId.y == 0 && cellId.x == 6){
			alpha =  L3_OUT_L;
	}
	if(cellId.y == 0 && cellId.x == 7){
			alpha =  L3_IN;
	}
	if(cellId.y == 0 && cellId.x == 8){
			alpha =  L3_OUT_R;
	}
	
	//caja 4
	if(cellId.y == 0 && cellId.x == 9){
			alpha =  L4_OUT_L;
	}
	if(cellId.y == 0 && cellId.x == 10){
			alpha =  L4_IN;
	}
	if(cellId.y == 0 && cellId.x == 11){
			alpha =  L4_OUT_R;
	}
	
	//caja 5
	if(cellId.y == 0 && cellId.x == 12){
			alpha =  L5_OUT_L;
	}
	if(cellId.y == 0 && cellId.x == 13){
			alpha =  L5_IN;
	}
	if(cellId.y == 0 && cellId.x == 14){
			alpha =  L5_OUT_R;
	}
	
	//caja 6
	if(cellId.y == 0 && cellId.x == 15){
			alpha =  L6_OUT_L;
	}
	if(cellId.y == 0 && cellId.x == 16){
			alpha =  L6_IN;
	}
	if(cellId.y == 0 && cellId.x == 17){
			alpha =  L6_OUT_R;
	}
	
	//Caja7
	if(cellId.y == 0 && cellId.x == 18){
			alpha =  L7_OUT_L;
	}
	
	if(cellId.y == 0 && cellId.x == 19){
			alpha =  L7_IN;
	}
	
	if(cellId.y == 0 && cellId.x == 20){
			alpha =  L7_OUT_R;
	}
	
	//caja 8
	if(cellId.y == 0 && cellId.x == 21){
			alpha =  L8_OUT_L;
	}
	if(cellId.y == 0 && cellId.x == 22){
			alpha =  L8_IN;
	}
	if(cellId.y == 0 && cellId.x == 23){
			alpha =  L8_OUT_R;
	}
	
	//caja 9
	if(cellId.y == 0 && cellId.x == 24){
			alpha =  L9_OUT_L;
	}
	if(cellId.y == 0 && cellId.x == 25){
			alpha =  L9_IN;
	}
	if(cellId.y == 0 && cellId.x == 26){
			alpha =  L9_OUT_R;
	}
	
	//caja 10
	if(cellId.y == 0 && cellId.x == 27){
			alpha =  L10_OUT_L;
	}
	if(cellId.y == 0 && cellId.x == 28){
			alpha =  L10_IN;
	}
	if(cellId.y == 0 && cellId.x == 29){
			alpha =  L10_OUT_R;
	}
	
	//caja 11
	if(cellId.y == 0 && cellId.x == 30){
			alpha =  L11_OUT_L;
	}
	if(cellId.y == 0 && cellId.x == 31){
			alpha =  L11_IN;
	}
	if(cellId.y == 0 && cellId.x == 32){
			alpha =  L11_OUT_R;
	}
	
	//caja 12
	if(cellId.y == 0 && cellId.x == 33){
			alpha =  L12_OUT_L;
	}
	if(cellId.y == 0 && cellId.x == 34){
			alpha =  L12_IN;
	}
	if(cellId.y == 0 && cellId.x == 35){
			alpha =  L12_OUT_R;
	}
	
	//caja 13
	if(cellId.y == 0 && cellId.x == 36){
			alpha =  L13_OUT_L;
	}
	if(cellId.y == 0 && cellId.x == 37){
			alpha =  L13_IN;
	}
	if(cellId.y == 0 && cellId.x == 38){
			alpha =  L13_OUT_R;
	}

	//caja 14
	if(cellId.y == 0 && cellId.x == 39){
			alpha =  L14_OUT_L;
	}
	if(cellId.y == 0 && cellId.x == 40){
			alpha =  L14_IN;
	}
	if(cellId.y == 0 && cellId.x == 41){
			alpha =  L14_OUT_R;
	}

	//caja 15
	if(cellId.y == 0 && cellId.x == 42){
			alpha =  L15_OUT_L;
	}
	if(cellId.y == 0 && cellId.x == 43){
			alpha =  L15_IN;
	}
	if(cellId.y == 0 && cellId.x == 44){
			alpha =  L15_OUT_R;
	}

	//caja 16
	if(cellId.y == 1 && cellId.x == 0){
			alpha =  L16_OUT_L;
	}
	if(cellId.y == 1 && cellId.x == 1){
			alpha =  L16_IN;
	}
	if(cellId.y == 1 && cellId.x == 2){
			alpha =  L16_OUT_R;
	}

	//caja 17
	if(cellId.y == 1 && cellId.x == 3){
			alpha =  L17_OUT_L;
	}
	if(cellId.y == 1 && cellId.x == 4){
			alpha =  L17_IN;
	}
	if(cellId.y == 1 && cellId.x == 5){
			alpha =  L17_OUT_R;
	}

	//caja 18
	if(cellId.y == 1 && cellId.x == 6){
			alpha =  L18_OUT_L;
	}
	if(cellId.y == 1 && cellId.x == 7){
			alpha =  L18_IN;
	}
	if(cellId.y == 1 && cellId.x == 8){
			alpha =  L18_OUT_R;
	}

	//caja 19
	if(cellId.y == 1 && cellId.x == 9){
			alpha =  L19_OUT_L;
	}
	if(cellId.y == 1 && cellId.x == 10){
			alpha =  L19_IN;
	}
	if(cellId.y == 1 && cellId.x == 11){
			alpha =  L19_OUT_R;
	}

	//caja 20
	if(cellId.y == 1 && cellId.x == 12){
			alpha =  L20_OUT_L;
	}
	if(cellId.y == 1 && cellId.x == 13){
			alpha =  L20_IN;
	}
	if(cellId.y == 1 && cellId.x == 14){
			alpha =  L20_OUT_R;
	}

	//caja 21
	if(cellId.y == 1 && cellId.x == 15){
			alpha =  L21_OUT_L;
	}
	if(cellId.y == 1 && cellId.x == 16){
			alpha =  L21_IN;
	}
	if(cellId.y == 1 && cellId.x == 17){
			alpha =  L21_OUT_R;
	}

	//caja 22
	if(cellId.y == 1 && cellId.x == 18){
			alpha =  L22_OUT_L;
	}
	if(cellId.y == 1 && cellId.x == 19){
			alpha =  L22_IN;
	}
	if(cellId.y == 1 && cellId.x == 20){
			alpha =  L22_OUT_R;
	}

	//caja 23
	if(cellId.y == 1 && cellId.x == 21){
			alpha =  L23_OUT_L;
	}
	if(cellId.y == 1 && cellId.x == 22){
			alpha =  L23_IN;
	}
	if(cellId.y == 1 && cellId.x == 23){
			alpha =  L23_OUT_R;
	}

	//caja 24
	if(cellId.y == 1 && cellId.x == 24){
			alpha =  L24_OUT_L;
	}
	if(cellId.y == 1 && cellId.x == 25){
			alpha =  L24_IN;
	}
	if(cellId.y == 1 && cellId.x == 26){
			alpha =  L24_OUT_R;
	}

	//caja 25
	if(cellId.y == 1 && cellId.x == 27){
			alpha =  L25_OUT_L;
	}
	if(cellId.y == 1 && cellId.x == 28){
			alpha =  L25_IN;
	}
	if(cellId.y == 1 && cellId.x == 29){
			alpha =  L25_OUT_R;
	}

	//caja 26
	if(cellId.y == 1 && cellId.x == 30){
			alpha =  L26_OUT_L;
	}
	if(cellId.y == 1 && cellId.x == 31){
			alpha =  L26_IN;
	}
	if(cellId.y == 1 && cellId.x == 32){
			alpha =  L26_OUT_R;
	}

	//caja 27
	if(cellId.y == 1 && cellId.x == 33){
			alpha =  L27_OUT_L;
	}
	if(cellId.y == 1 && cellId.x == 34){
			alpha =  L27_IN;
	}
	if(cellId.y == 1 && cellId.x == 35){
			alpha =  L27_OUT_R;
	}

	//caja 28
	if(cellId.y == 1 && cellId.x == 36){
			alpha =  L28_OUT_L;
	}
	if(cellId.y == 1 && cellId.x == 37){
			alpha =  L28_IN;
	}
	if(cellId.y == 1 && cellId.x == 38){
			alpha =  L28_OUT_R;
	}

	//caja 29
	if(cellId.y == 1 && cellId.x == 39){
			alpha =  L29_OUT_L;
	}
	if(cellId.y == 1 && cellId.x == 40){
			alpha =  L29_IN;
	}
	if(cellId.y == 1 && cellId.x == 41){
			alpha =  L29_OUT_R;
	}

	//caja 30
	if(cellId.y == 1 && cellId.x == 42){
			alpha =  L30_OUT_L;
	}
	if(cellId.y == 1 && cellId.x == 43){
			alpha =  L30_IN;
	}
	if(cellId.y == 1 && cellId.x == 44){
			alpha =  L30_OUT_R;
	}

	//caja 31
	if(cellId.y == 2 && cellId.x == 0){
			alpha =  L31_OUT_L;
	}
	if(cellId.y == 2 && cellId.x == 1){
			alpha =  L31_IN;
	}
	if(cellId.y == 2 && cellId.x == 2){
			alpha =  L31_OUT_R;
	}

	//caja 32
	if(cellId.y == 2 && cellId.x == 3){
			alpha =  L32_OUT_L;
	}
	if(cellId.y == 2 && cellId.x == 4){
			alpha =  L32_IN;
	}
	if(cellId.y == 2 && cellId.x == 5){
			alpha =  L32_OUT_R;
	}

	//caja 33
	if(cellId.y == 2 && cellId.x == 6){
			alpha =  L33_OUT_L;
	}
	if(cellId.y == 2 && cellId.x == 7){
			alpha =  L33_IN;
	}
	if(cellId.y == 2 && cellId.x == 8){
			alpha =  L33_OUT_R;
	}

	//caja 34
	if(cellId.y == 2 && cellId.x == 9){
			alpha =  L34_OUT_L;
	}
	if(cellId.y == 2 && cellId.x == 10){
			alpha =  L34_IN;
	}
	if(cellId.y == 2 && cellId.x == 11){
			alpha =  L34_OUT_R;
	}


	//caja 35
	if(cellId.y == 2 && cellId.x == 12){
			alpha =  L35_OUT_L;
	}
	if(cellId.y == 2 && cellId.x == 13){
			alpha =  L35_IN;
	}
	if(cellId.y == 2 && cellId.x == 14){
			alpha =  L35_OUT_R;
	}

	//caja 36
	if(cellId.y == 2 && cellId.x == 15){
			alpha =  L36_OUT_L;
	}
	if(cellId.y == 2 && cellId.x == 16){
			alpha =  L36_IN;
	}
	if(cellId.y == 2 && cellId.x == 17){
			alpha =  L36_OUT_R;
	}

	//caja 37
	if(cellId.y == 2 && cellId.x == 18){
			alpha =  L37_OUT_L;
	}
	if(cellId.y == 2 && cellId.x == 19){
			alpha =  L37_IN;
	}
	if(cellId.y == 2 && cellId.x == 20){
			alpha =  L37_OUT_R;
	}

	//caja 38
	if(cellId.y == 2 && cellId.x == 21){
			alpha =  L38_OUT_L;
	}
	if(cellId.y == 2 && cellId.x == 22){
			alpha =  L38_IN;
	}
	if(cellId.y == 2 && cellId.x == 23){
			alpha =  L38_OUT_R;
	}



    radius *= size;

	float dist = rectangle( p, radius );

    vec4 backColor = vec4(backgroundColor.rgb * brightness, 1);
    vec4 frontColor = vec4(foregroundColor.rgb * brightness, 1);

	
	
    vec4 col = alpha * stroke( backColor, frontColor, dist, 1 );

    col.a = 1.0;
    return col;
}
