using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceManager
{
    public class Material
    {

        //"depthWrite":true,
        //"colorEmissive":[0,0,0],
        //"opacity":1,
        //"shading":"phong",
        //"depthTest":true,
        //"visible":true,
        //"colorSpecular":[0.5,0.5,0.5],
        //"blending":1,
        //"specularCoef":70,
        //"colorDiffuse":[0.0485728,0.0485728,0.0485728],
        //"wireframe":false,
        //"doubleSided":false,
        //"transparent":false,
        //"DbgColor":15597568,
        //"DbgIndex":1,
        //"DbgName":"Rubber Black"

        public string name { get; set; }
        public float[] colorEmissive { get; set; }
        public float opacity { get; set; }
        public float[] colorDiffuse { get; set; }
        public int specularCoef { get; set; }
        public float roughness { get; set; }
        public float[] tiling { get; set; }
        public string map { get; set; }
        public string normalMap { get; set; }
        public string roughnessMap { get; set; }
    }
}
