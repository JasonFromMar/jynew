using UnityEngine;
using UnityEngine.UI;

public partial class GameMainMenu
{
	private RectTransform mainPanel_RectTransform;
	private RectTransform homeBtnAndTxtPanel_RectTransform;
	private Button NewGameButton_Button;
	private Button LoadGameButton_Button;
	private Button QuitGameButton_Button;
	private RectTransform SavePanel_RectTransform;
	private RectTransform savePanelContainer_RectTransform;
	private Button BackButton_Button;
	private RectTransform InfoPanel_RectTransform;
	private RectTransform InputNamePanel_RectTransform;
	private InputField NameInput_InputField;
	private Button inputSure_Button;
    private Button inputBack_Button;
    private RectTransform StartNewRolePanel_RectTransform;
	private Button NoBtn_Button;
	private Button YesBtn_Button;
	private RectTransform PropertyItem_RectTransform;
	private RectTransform PropertyRoot_RectTransform;

	public void InitTrans()
	{
		mainPanel_RectTransform = transform.Find("mainPanel").GetComponent<RectTransform>();
		homeBtnAndTxtPanel_RectTransform = transform.Find("mainPanel/homeBtnAndTxtPanel").GetComponent<RectTransform>();
		NewGameButton_Button = transform.Find("mainPanel/homeBtnAndTxtPanel/NewGameButton").GetComponent<Button>();
		LoadGameButton_Button = transform.Find("mainPanel/homeBtnAndTxtPanel/LoadGameButton").GetComponent<Button>();
		QuitGameButton_Button = transform.Find("mainPanel/homeBtnAndTxtPanel/QuitGameButton").GetComponent<Button>();
		SavePanel_RectTransform = transform.Find("SavePanel").GetComponent<RectTransform>();
		savePanelContainer_RectTransform = transform.Find("SavePanel/savePanelContainer").GetComponent<RectTransform>();
		BackButton_Button = transform.Find("SavePanel/BackButton").GetComponent<Button>();
		InfoPanel_RectTransform = transform.Find("InfoPanel").GetComponent<RectTransform>();
		InputNamePanel_RectTransform = transform.Find("InputNamePanel").GetComponent<RectTransform>();
		NameInput_InputField = transform.Find("InputNamePanel/NameInput").GetComponent<InputField>();
		inputSure_Button = transform.Find("InputNamePanel/inputSure").GetComponent<Button>();
        inputBack_Button = transform.Find("InputNamePanel/inputBack").GetComponent<Button>();
        StartNewRolePanel_RectTransform = transform.Find("StartNewRolePanel").GetComponent<RectTransform>();
		NoBtn_Button = transform.Find("StartNewRolePanel/NoBtn").GetComponent<Button>();
		YesBtn_Button = transform.Find("StartNewRolePanel/YesBtn").GetComponent<Button>();
		PropertyItem_RectTransform = transform.Find("StartNewRolePanel/PropertyItem").GetComponent<RectTransform>();
		PropertyRoot_RectTransform = transform.Find("StartNewRolePanel/PropertyRoot").GetComponent<RectTransform>();

	}
}
