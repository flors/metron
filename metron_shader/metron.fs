/*{
    "CREDIT": "Metron",
    "DESCRIPTION": "describe your material here",
    "TAGS": "graphic",
    "VSN": "1.0",
    "INPUTS": [ 
	  
        { "LABEL": "Size", "NAME": "size", "TYPE": "float", "MIN": 0.0, "MAX": 1.0, "DEFAULT": 1 },
        { "LABEL": "Cells/Cells X", "NAME": "cells_x", "TYPE": "int", "MIN": 1, "MAX": 16, "DEFAULT": 1 },
        { "LABEL": "Cells/Cells Y", "NAME": "cells_y", "TYPE": "int", "MIN": 1, "MAX": 16, "DEFAULT": 1 },

       	{ "LABEL": "LEDS/alpha_L1", "NAME": "led_1", "TYPE": "float", "MIN":  0.0, "MAX":  1.0, "DEFAULT": 0},
		{ "LABEL": "LEDS/alpha_L2", "NAME": "led_2", "TYPE": "float", "MIN":  0.0, "MAX":  1.0, "DEFAULT": 0},
		{ "LABEL": "LEDS/alpha_L3", "NAME": "led_3", "TYPE": "float", "MIN":  0.0, "MAX":  1.0, "DEFAULT": 0},
		{ "LABEL": "LEDS/alpha_L4", "NAME": "led_4", "TYPE": "float", "MIN":  0.0, "MAX":  1.0, "DEFAULT": 0},
	   
   
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
    vec2 cellSize   = vec2( 1.0 / cells_x, 1.0 / cells_y );
    p               = repeat( p, cellSize, cellId );

    vec2 radius = cellSize * 0.5;
	float alpha = 0.5;
	
	
	switch(int(cellId.y)){
			
			case 0: 
				alpha =  led_1;
			break;
			case 1:
				alpha =  led_2;
			break;
			case 2:
				alpha =  led_3;
			break;
			case 3:
				alpha =  led_4;
			break;
			
			
	}
	


    radius *= size;

	float dist = rectangle( p, radius );

    vec4 backColor = vec4(backgroundColor.rgb * brightness, 1);
    vec4 frontColor = vec4(foregroundColor.rgb * brightness, 1);

	
	
    vec4 col = alpha * stroke( backColor, frontColor, dist, 1 );

    col.a = 1.0;
    return col;
}
