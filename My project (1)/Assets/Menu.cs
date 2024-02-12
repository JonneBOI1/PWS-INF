using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Menu : MonoBehaviour {

    [Header("References")]
    [SerializeField] TextMeshProUGUI currecyUI;
    [SerializeField] TextMeshProUGUI levensUI;
    [SerializeField] Animator anim;

    private bool isMenuOpen = true;

    public void ToggleMenu() {
        isMenuOpen = !isMenuOpen;
        anim.SetBool("MenuOpen", isMenuOpen);
    }

    private void OnGUI() {
        currecyUI.text = LevelManager.main.geld.ToString();
        levensUI.text = LevelManager.main.huidigeLevens.ToString();
    }

    public void SetSelected() {

    }
}
