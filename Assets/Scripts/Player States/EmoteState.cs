using UnityEngine;


public class EmoteState : State
{

    public EmoteState(PlayerScript player, StateMachine sm) : base(player, sm)
    {
    }

    public override void Enter()
    {
        // this method is called when the state begins
        player.anim.SetBool("isEmote", true);
        Debug.Log("entering emote state");
    }

    public override void Exit()
    {
        player.anim.SetBool("isEmote", false);
        base.Exit();
    }


    public override void Update()
    {
        if (player.moveAction.ReadValue<Vector2>().magnitude > 0.1f)
        {
            sm.ChangeState(sm.runState);
        }

        if (player.jumpAction.IsPressed())
        {
            sm.ChangeState(sm.jumpState);
        }




        /*UIscript.ui.DrawText("*** This is the emote state ***\n");
        UIscript.ui.DrawText("Space = Jump State");
        UIscript.ui.DrawText("Left/Right arrows = Move State");
        UIscript.ui.DrawText("C = Start the coroutine");*/


    }

    public override void FixedUpdate()
    {
    }

    public override void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("collided");
    }

}
