using UnityEngine;

[ExecuteInEditMode]
public class FCP_SpriteMeshEditor : MonoBehaviour {

    public int x, y;
    public Sprite sprite;

    void Update() {
        if(sprite != null) {
            MakeMesh(sprite, x, y);
            Debug.Log("Set sprite mesh to " + x + "x" + y + " resolution");
            sprite = null;
            return;
        }
    }

    private void MakeMesh(Sprite sprite, int x, int y) {
        int nx = x - 1;
        int ny = y - 1;
        int t = x * y;
        Vector2[] verts = new Vector2[t + (nx * ny)];
        ushort[] faces = new ushort[nx * ny * 12];
        for(int i = 0; i < x; i++) {
            float xi = (float)i / nx;
            for(int j = 0; j < y; j++) {
                float yi = (float)j / ny;
                verts[x * j + i] = new Vector2(xi, yi);
            }
        }
        for(int i = 0; i < nx; i++) {
            float xi = (i + .5f) / nx;
            for(int j = 0; j < ny; j++) {
                float yi = (j + .5f) / ny;
                verts[j * nx + i + t] = new Vector2(xi, yi);
            }
        }
        for(int i = 0; i < nx; i++) {
            for(int j = 0; j < ny; j++) {
                int f = 12 * (j * nx + i);
                int s = (j * x + i);
                ushort ns = (ushort)(j * nx + i + t);
                faces[f + 11] = faces[f] = (ushort)s;
                faces[f + 3] = faces[f + 2] = (ushort)(s + 1);
                faces[f + 6] = faces[f + 5] = (ushort)(s + x + 1);
                faces[f + 9] = faces[f + 8] = (ushort)(s + x);
                faces[f + 1] = faces[f + 4] = faces[f + 7] = faces[f + 10] = ns;
            }
        }
        sprite.OverrideGeometry(verts, faces);
    }
}
