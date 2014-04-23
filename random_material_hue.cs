using UnityEngine;
using System.Collections;

public class random_material_hue : MonoBehaviour
 {
 	public Material[] materials_to_change;
 	public float saturation = 1.0f;
 	public float brightness_color = 1.0f;
 	public float alpha = 1.0f;

	// Update is called once per frame
	void Update ()
	{

		HSBColor new_color = new HSBColor(Random.value,saturation,brightness_color,alpha);
		foreach(Material mat in materials_to_change)
		{
			mat.color = new_color.ToColor();
		}
	}
}
