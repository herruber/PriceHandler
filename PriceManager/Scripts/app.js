
var material = new THREE.MeshStandardMaterial();

var scene = new THREE.Scene();

var renderer = new THREE.WebGLRenderer();

var camera = new THREE.PerspectiveCamera();
camera.position.z = 4;
camera.lookAt(0, 0, 0);

var light = new THREE.DirectionalLight();
light.shadow.camera.left = -20;
light.shadow.camera.right = 20;
light.shadow.camera.top = 20;
light.shadow.camera.bottom = -20;

var sphere = new THREE.Mesh(new THREE.SphereGeometry(1, 32, 32), material);

scene.add(sphere, light, camera);


function render() {

    var p = performance.now() / 2000;
    light.position.set(Math.cos(p), 0, Math.sin(p));
     console.log(scene)
    renderer.render(scene, camera);
    requestAnimationFrame(render);
}


function run(elem) {

    console.log("basjds")
    renderer.setSize(elem.clientWidth, elem.clientHeight);

    elem.appendChild(renderer.domElement);
    render();
}

run(document.getElementById("render-view"));