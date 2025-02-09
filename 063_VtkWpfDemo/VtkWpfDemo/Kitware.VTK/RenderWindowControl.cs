using System;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Kitware.VTK;

/// <summary>
/// UserControl derived implementation of vtkRenderWindow for use
/// in Windows Forms applications.
/// The client area of this UserControl is completely filled with
/// an instance of a vtkRenderWindow.
/// </summary>
/// 
[System.Runtime.Versioning.SupportedOSPlatform("windows")]
[ClassInterface(ClassInterfaceType.AutoDual)]
[ComVisible(true)]
public class RenderWindowControl : UserControl
{
	private vtkRenderer m_Renderer;

	private vtkRenderWindow m_RenderWindow;

	private vtkRenderWindowInteractor m_RenderWindowInteractor;

	private string m_TestText;

	private bool m_AddTestActors = false;

	private bool m_AddedTestActors = false;

	/// <summary>
	/// Required designer variable.
	/// </summary>
	private IContainer components = null;

	private IntPtr XDisplay;

	private bool AttachedInteractor;

	/// <summary>
	/// This property gives you access to the vtkRenderWindow that
	/// fills the client area.
	/// </summary>
	public vtkRenderWindow RenderWindow => m_RenderWindow;

	/// <summary>
	/// Text property for test purposes.
	/// </summary>
	public string TestText
	{
		get
		{
			return m_TestText;
		}
		set
		{
			m_TestText = value;
		}
	}

	/// <summary>
	/// Bool property for test purposes. If true, VTK actors will be added to
	/// the render window in OnHandleCreated.
	/// </summary>
	public bool AddTestActors
	{
		get
		{
			return m_AddTestActors;
		}
		set
		{
			m_AddTestActors = value;
		}
	}

	/// <summary>
	/// UserControl derived implementation of vtkRenderWindow for use
	/// in Windows Forms applications.
	/// The client area of this UserControl is completely filled with
	/// an instance of a vtkRenderWindow.
	/// </summary>
	public RenderWindowControl()
	{
		InitializeComponent();
	}

	/// <summary>
	/// TestAddActorsToRenderWindow.
	/// </summary>
	private void TestAddActorsToRenderWindow(vtkRenderWindow renWin)
	{
		vtkConeSource vtkConeSource2 = new vtkConeSource();
		vtkMapper vtkMapper2 = vtkPolyDataMapper.New();
		vtkMapper2.SetInputConnection(vtkConeSource2.GetOutputPort());
		vtkActor vtkActor2 = new vtkActor();
		vtkActor2.SetMapper(vtkMapper2);
		vtkRenderer vtkRenderer2 = null;
		vtkRenderer2 = renWin.GetRenderers().GetFirstRenderer();
		vtkRenderer2.AddActor(vtkActor2);
		vtkTextActor vtkTextActor2 = new vtkTextActor();
		vtkTextActor2.SetInput(vtkVersion.GetVTKSourceVersion());
		vtkRenderer2.AddActor(vtkTextActor2);
	}

	/// <summary>
	/// Clean up any resources being used.
	/// </summary>
	/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			base.Dispose(disposing);
		}
	}

	/// <summary>
	/// Called to set the vtkRenderWindow size according to this control's
	/// Size property.
	/// </summary>
	internal void SyncRenderWindowSize()
	{
		if (m_RenderWindow != null)
		{
			m_RenderWindow.SetSize(base.Size.Width, base.Size.Height);
		}
	}

	/// <summary>
	/// Retrieve the X11 Display* to pass to VTK's vtkRenderWindow::SetDisplayId
	/// </summary>
	private IntPtr GetXDisplay()
	{
		Type type = Type.GetType("System.Windows.Forms.XplatUIX11, System.Windows.Forms");
		if (type != null)
		{
			IntPtr intPtr = (XDisplay = (IntPtr)type.GetField("DisplayHandle", BindingFlags.Static | BindingFlags.NonPublic).GetValue(null));
		}
		return XDisplay;
	}

	private void AttachInteractor()
	{
		if (!AttachedInteractor)
		{
			AttachedInteractor = true;
			m_RenderWindow.SetInteractor(m_RenderWindowInteractor);
		}
	}

	/// <summary>
	/// OnHandleCreated.
	/// </summary>
	protected override void OnHandleCreated(EventArgs e)
	{
		if (!base.DesignMode)
		{
			vtkLogoWidget vtkLogoWidget2 = new vtkLogoWidget();
			m_Renderer = vtkRenderer.New();
			m_RenderWindow = vtkRenderWindow.New();
			IntPtr xDisplay = GetXDisplay();
			bool flag = false;
			if (IntPtr.Zero != xDisplay)
			{
				flag = true;
			}
			if (flag)
			{
				m_RenderWindowInteractor = vtkGenericRenderWindowInteractor.New();
				m_RenderWindow.SetDisplayId(xDisplay);
			}
			else
			{
				m_RenderWindowInteractor = vtkRenderWindowInteractor.New();
			}
			if (m_RenderWindowInteractor.GetInteractorStyle() is vtkInteractorStyleSwitch vtkInteractorStyleSwitch2)
			{
				vtkInteractorStyleSwitch2.SetCurrentStyleToTrackballCamera();
			}
			m_RenderWindow.SetParentId(base.Handle);
			m_RenderWindow.AddRenderer(m_Renderer);
			if (!flag)
			{
				AttachInteractor();
			}
			vtkLogoWidget2.Dispose();
		}
		base.OnHandleCreated(e);
	}

	/// <summary>
	/// OnHandleDestroyed.
	/// </summary>
	protected override void OnHandleDestroyed(EventArgs e)
	{
		if (m_Renderer != null)
		{
			m_Renderer.SetRenderWindow(null);
		}
		if (m_RenderWindowInteractor != null)
		{
			m_RenderWindowInteractor.Dispose();
			m_RenderWindowInteractor = null;
		}
		if (m_RenderWindow != null)
		{
			m_RenderWindow.Dispose();
			m_RenderWindow = null;
		}
		if (m_Renderer != null)
		{
			m_Renderer.Dispose();
			m_Renderer = null;
		}
		base.OnHandleDestroyed(e);
	}

	/// <summary>
	/// OnMouseDown.
	/// </summary>
	protected override void OnMouseDown(MouseEventArgs e)
	{
		if (m_RenderWindowInteractor is vtkGenericRenderWindowInteractor vtkGenericRenderWindowInteractor2)
		{
			vtkGenericRenderWindowInteractor2.SetEventInformationFlipY(e.X, e.Y, 0, 0, 0, e.Clicks, null);
			switch (e.Button)
			{
			case MouseButtons.Left:
				vtkGenericRenderWindowInteractor2.LeftButtonPressEvent();
				break;
			case MouseButtons.Middle:
				vtkGenericRenderWindowInteractor2.MiddleButtonPressEvent();
				break;
			case MouseButtons.Right:
				vtkGenericRenderWindowInteractor2.RightButtonPressEvent();
				break;
			}
		}
	}

	/// <summary>
	/// OnMouseMove.
	/// </summary>
	protected override void OnMouseMove(MouseEventArgs e)
	{
		if (m_RenderWindowInteractor is vtkGenericRenderWindowInteractor vtkGenericRenderWindowInteractor2)
		{
			vtkGenericRenderWindowInteractor2.SetEventInformationFlipY(e.X, e.Y, 0, 0, 0, e.Clicks, null);
			vtkGenericRenderWindowInteractor2.MouseMoveEvent();
		}
	}

	/// <summary>
	/// OnMouseUp.
	/// </summary>
	protected override void OnMouseUp(MouseEventArgs e)
	{
		if (m_RenderWindowInteractor is vtkGenericRenderWindowInteractor vtkGenericRenderWindowInteractor2)
		{
			vtkGenericRenderWindowInteractor2.SetEventInformationFlipY(e.X, e.Y, 0, 0, 0, e.Clicks, null);
			switch (e.Button)
			{
			case MouseButtons.Left:
				vtkGenericRenderWindowInteractor2.LeftButtonReleaseEvent();
				break;
			case MouseButtons.Middle:
				vtkGenericRenderWindowInteractor2.MiddleButtonReleaseEvent();
				break;
			case MouseButtons.Right:
				vtkGenericRenderWindowInteractor2.RightButtonReleaseEvent();
				break;
			}
		}
	}

	/// <summary>
	/// OnMouseWheel.
	/// </summary>
	protected override void OnMouseWheel(MouseEventArgs e)
	{
		if (m_RenderWindowInteractor is vtkGenericRenderWindowInteractor vtkGenericRenderWindowInteractor2)
		{
			vtkGenericRenderWindowInteractor2.SetEventInformationFlipY(e.X, e.Y, 0, 0, 0, e.Clicks, null);
			if (e.Delta > 0)
			{
				vtkGenericRenderWindowInteractor2.MouseWheelForwardEvent();
			}
			else
			{
				vtkGenericRenderWindowInteractor2.MouseWheelBackwardEvent();
			}
		}
	}

	/// <summary>
	/// OnKeyDown.
	/// </summary>
	protected override void OnKeyDown(KeyEventArgs e)
	{
		if (m_RenderWindowInteractor is vtkGenericRenderWindowInteractor vtkGenericRenderWindowInteractor2)
		{
			vtkGenericRenderWindowInteractor2.SetKeyEventInformation(e.Control ? 1 : 0, e.Shift ? 1 : 0, (sbyte)e.KeyCode, 1, null);
			vtkGenericRenderWindowInteractor2.KeyPressEvent();
		}
	}

	/// <summary>
	/// OnKeyPress.
	/// </summary>
	protected override void OnKeyPress(KeyPressEventArgs e)
	{
		if (m_RenderWindowInteractor is vtkGenericRenderWindowInteractor vtkGenericRenderWindowInteractor2)
		{
			vtkGenericRenderWindowInteractor2.SetKeyEventInformation(0, 0, (sbyte)e.KeyChar, 1, e.KeyChar.ToString());
			vtkGenericRenderWindowInteractor2.CharEvent();
		}
	}

	/// <summary>
	/// OnKeyUp.
	/// </summary>
	protected override void OnKeyUp(KeyEventArgs e)
	{
		if (m_RenderWindowInteractor is vtkGenericRenderWindowInteractor vtkGenericRenderWindowInteractor2)
		{
			vtkGenericRenderWindowInteractor2.SetKeyEventInformation(e.Control ? 1 : 0, e.Shift ? 1 : 0, (sbyte)e.KeyCode, 1, null);
			vtkGenericRenderWindowInteractor2.KeyReleaseEvent();
		}
	}

	/// <summary>
	/// OnSizeChanged fires after the Size property has changed value.
	/// </summary>
	protected override void OnSizeChanged(EventArgs e)
	{
		SyncRenderWindowSize();
		if (m_RenderWindowInteractor is vtkGenericRenderWindowInteractor vtkGenericRenderWindowInteractor2)
		{
			vtkGenericRenderWindowInteractor2.ConfigureEvent();
		}
		base.OnSizeChanged(e);
		Invalidate();
	}

	[DllImport("user32.dll")]
	internal static extern IntPtr SetFocus(IntPtr hWnd);

	/// <summary>
	/// OnGotFocus fires after Windows keyboard focus enters the control.
	/// </summary>
	protected override void OnGotFocus(EventArgs e)
	{
		if (m_RenderWindow != null)
		{
			IntPtr genericWindowId = m_RenderWindow.GetGenericWindowId();
			if (IntPtr.Zero != genericWindowId)
			{
				try
				{
					SetFocus(genericWindowId);
				}
				catch
				{
				}
			}
		}
		base.OnGotFocus(e);
	}

	/// <summary>
	/// Override to do "last minute cram" of child control...
	/// </summary>
	protected override void OnPaint(PaintEventArgs e)
	{
		if (m_RenderWindow != null && base.Visible)
		{
			SyncRenderWindowSize();
			if (m_RenderWindow.GetInteractor() != m_RenderWindowInteractor)
			{
				AttachInteractor();
				m_RenderWindow.Render();
			}
			if (AddTestActors && !m_AddedTestActors)
			{
				m_AddedTestActors = true;
				TestAddActorsToRenderWindow(m_RenderWindow);
			}
			m_RenderWindow.Render();
		}
		base.OnPaint(e);
	}

	/// <summary>
	/// OnVisibleChanged fires after the Visible property has changed value.
	/// </summary>
	protected override void OnVisibleChanged(EventArgs e)
	{
		base.OnVisibleChanged(e);
	}

	/// <summary>
	/// Required method for Designer support - do not modify 
	/// the contents of this method with the code editor.
	/// </summary>
	private void InitializeComponent()
	{
		base.SuspendLayout();
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.Name = "RenderWindowControl";
		base.Size = new System.Drawing.Size(400, 300);
		base.ResumeLayout(false);
	}
}
