Module Module1

    Declare Sub ENepanet Lib "C:\tmp\epanet_toolkit_example_vb\epanet_toolkit_example_vb\bin\Debug\epanet2.dll" (ByVal f1 As String, ByVal f2 As String, ByVal f3 As String)

    Declare Sub ENopen Lib "C:\tmp\epanet_toolkit_example_vb\epanet_toolkit_example_vb\bin\Debug\epanet2.dll" (ByVal inpfile As String, ByVal reportfile As String, ByVal binaryresultfile As String)
    Declare Sub ENsaveinpfile Lib "C:\tmp\epanet_toolkit_example_vb\epanet_toolkit_example_vb\bin\Debug\epanet2.dll" (ByVal inpfile As String)
    Declare Sub ENclose Lib "C:\tmp\epanet_toolkit_example_vb\epanet_toolkit_example_vb\bin\Debug\epanet2.dll" ()

    Declare Sub ENsolveH Lib "C:\tmp\epanet_toolkit_example_vb\epanet_toolkit_example_vb\bin\Debug\epanet2.dll" ()
    Declare Sub ENsaveH Lib "C:\tmp\epanet_toolkit_example_vb\epanet_toolkit_example_vb\bin\Debug\epanet2.dll" ()
    Declare Sub ENopenH Lib "C:\tmp\epanet_toolkit_example_vb\epanet_toolkit_example_vb\bin\Debug\epanet2.dll" ()
    Declare Sub ENinitH Lib "C:\tmp\epanet_toolkit_example_vb\epanet_toolkit_example_vb\bin\Debug\epanet2.dll" (ByVal timestep As Integer)
    Declare Sub ENrunH Lib "C:\tmp\epanet_toolkit_example_vb\epanet_toolkit_example_vb\bin\Debug\epanet2.dll" (ByRef timestep As Integer)
    Declare Sub ENnextH Lib "C:\tmp\epanet_toolkit_example_vb\epanet_toolkit_example_vb\bin\Debug\epanet2.dll" (ByRef timestep As Integer)
    Declare Sub ENcloseH Lib "C:\tmp\epanet_toolkit_example_vb\epanet_toolkit_example_vb\bin\Debug\epanet2.dll" ()
    Declare Sub ENsavehydfile Lib "C:\tmp\epanet_toolkit_example_vb\epanet_toolkit_example_vb\bin\Debug\epanet2.dll" (ByVal hydfile As String)
    Declare Sub ENusehydfile Lib "C:\tmp\epanet_toolkit_example_vb\epanet_toolkit_example_vb\bin\Debug\epanet2.dll" (ByVal hydfile As String)

    Declare Sub ENsolveQ Lib "C:\tmp\epanet_toolkit_example_vb\epanet_toolkit_example_vb\bin\Debug\epanet2.dll" ()
    Declare Sub ENopenQ Lib "C:\tmp\epanet_toolkit_example_vb\epanet_toolkit_example_vb\bin\Debug\epanet2.dll" ()
    Declare Sub ENinitQ Lib "C:\tmp\epanet_toolkit_example_vb\epanet_toolkit_example_vb\bin\Debug\epanet2.dll" (ByVal timestep As Integer)
    Declare Sub ENrunQ Lib "C:\tmp\epanet_toolkit_example_vb\epanet_toolkit_example_vb\bin\Debug\epanet2.dll" (ByRef timestep As Integer)
    Declare Sub ENstepQ Lib "C:\tmp\epanet_toolkit_example_vb\epanet_toolkit_example_vb\bin\Debug\epanet2.dll" (ByRef timestep As Integer)
    Declare Sub ENcloseQ Lib "C:\tmp\epanet_toolkit_example_vb\epanet_toolkit_example_vb\bin\Debug\epanet2.dll" ()

    Declare Sub ENwriteline Lib "C:\tmp\epanet_toolkit_example_vb\epanet_toolkit_example_vb\bin\Debug\epanet2.dll" (ByVal line As String)
    Declare Sub ENreport Lib "C:\tmp\epanet_toolkit_example_vb\epanet_toolkit_example_vb\bin\Debug\epanet2.dll" ()
    Declare Sub ENresetreport Lib "C:\tmp\epanet_toolkit_example_vb\epanet_toolkit_example_vb\bin\Debug\epanet2.dll" ()
    Declare Sub ENsetreport Lib "C:\tmp\epanet_toolkit_example_vb\epanet_toolkit_example_vb\bin\Debug\epanet2.dll" ()

    Declare Sub ENgetcontrol Lib "C:\tmp\epanet_toolkit_example_vb\epanet_toolkit_example_vb\bin\Debug\epanet2.dll" (ByVal cindex As Integer, ByRef ictype As Integer, ByRef lindex As Integer, ByRef setting As Single, ByRef nindex As Integer, ByRef level As Single)
    Declare Sub ENgetcount Lib "C:\tmp\epanet_toolkit_example_vb\epanet_toolkit_example_vb\bin\Debug\epanet2.dll" (ByVal type As Integer, ByRef count As Integer)
    Declare Sub ENgetoption Lib "C:\tmp\epanet_toolkit_example_vb\epanet_toolkit_example_vb\bin\Debug\epanet2.dll" (ByVal code As Integer, ByRef value As Single)
    Declare Sub ENgettimeparam Lib "C:\tmp\epanet_toolkit_example_vb\epanet_toolkit_example_vb\bin\Debug\epanet2.dll" (ByVal code As Integer, ByRef value As Single)
    Declare Sub ENgetflowunits Lib "C:\tmp\epanet_toolkit_example_vb\epanet_toolkit_example_vb\bin\Debug\epanet2.dll" (ByRef code As Integer)
    Declare Sub ENgetpatternindex Lib "C:\tmp\epanet_toolkit_example_vb\epanet_toolkit_example_vb\bin\Debug\epanet2.dll" (ByVal id As String, ByRef index As Integer)
    Declare Sub ENgetpatternid Lib "C:\tmp\epanet_toolkit_example_vb\epanet_toolkit_example_vb\bin\Debug\epanet2.dll" (ByVal index As Integer, ByRef id As String)
    Declare Sub ENgetpatternlen Lib "C:\tmp\epanet_toolkit_example_vb\epanet_toolkit_example_vb\bin\Debug\epanet2.dll" (ByVal index As Integer, ByRef len As Integer)
    Declare Sub ENgetpatternvalue Lib "C:\tmp\epanet_toolkit_example_vb\epanet_toolkit_example_vb\bin\Debug\epanet2.dll" (ByVal index As Integer, ByVal period As Integer, ByRef value As Single)
    Declare Sub ENgetqualtype Lib "C:\tmp\epanet_toolkit_example_vb\epanet_toolkit_example_vb\bin\Debug\epanet2.dll" (ByRef qualcode As Integer, ByRef tracenode As Integer)
    Declare Sub ENgeterror Lib "C:\tmp\epanet_toolkit_example_vb\epanet_toolkit_example_vb\bin\Debug\epanet2.dll" (ByVal errcode As Integer, ByRef errmsg As String, ByVal n As Integer)

    Declare Sub ENgetnodeindex Lib "C:\tmp\epanet_toolkit_example_vb\epanet_toolkit_example_vb\bin\Debug\epanet2.dll" (ByVal id As String, ByRef index As Integer)
    Declare Sub ENgetnodeid Lib "C:\tmp\epanet_toolkit_example_vb\epanet_toolkit_example_vb\bin\Debug\epanet2.dll" (ByVal index As Integer, ByVal id As String)
    Declare Sub ENgetnodetype Lib "C:\tmp\epanet_toolkit_example_vb\epanet_toolkit_example_vb\bin\Debug\epanet2.dll" (ByVal index As Integer, ByRef code As Integer)
    Declare Sub ENgetnodevalue Lib "C:\tmp\epanet_toolkit_example_vb\epanet_toolkit_example_vb\bin\Debug\epanet2.dll" (ByVal timestep As Integer, ByVal type As Integer, ByRef value As Single)
    Declare Sub ENgetlinkindex Lib "C:\tmp\epanet_toolkit_example_vb\epanet_toolkit_example_vb\bin\Debug\epanet2.dll" (ByVal id As String, ByRef index As Integer)
    Declare Sub ENgetlinkid Lib "C:\tmp\epanet_toolkit_example_vb\epanet_toolkit_example_vb\bin\Debug\epanet2.dll" (ByVal index As Integer, ByVal id As String)
    Declare Sub ENgetlinktype Lib "C:\tmp\epanet_toolkit_example_vb\epanet_toolkit_example_vb\bin\Debug\epanet2.dll" (ByVal index As Integer, ByRef code As Integer)
    Declare Sub ENgetlinknodes Lib "C:\tmp\epanet_toolkit_example_vb\epanet_toolkit_example_vb\bin\Debug\epanet2.dll" (ByVal index As Integer, ByRef node1 As Integer, ByRef node2 As Integer)
    Declare Sub ENgetlinkvalue Lib "C:\tmp\epanet_toolkit_example_vb\epanet_toolkit_example_vb\bin\Debug\epanet2.dll" (ByVal timestep As Integer, ByVal type As Integer, ByRef value As Single)

    Declare Sub ENgetversion Lib "C:\tmp\epanet_toolkit_example_vb\epanet_toolkit_example_vb\bin\Debug\epanet2.dll" (ByRef version As Integer)

    Declare Sub ENsetcontrol Lib "C:\tmp\epanet_toolkit_example_vb\epanet_toolkit_example_vb\bin\Debug\epanet2.dll" (ByVal cindex As Integer, ByVal ictype As Integer, ByVal lindex As Integer, ByVal setting As Single, ByVal nindex As Integer, ByVal level As Single)
    Declare Sub ENsetnodevalue Lib "C:\tmp\epanet_toolkit_example_vb\epanet_toolkit_example_vb\bin\Debug\epanet2.dll" (ByVal index As Integer, ByVal code As Integer, ByVal v As Single)
    Declare Sub ENsetlinkvalue Lib "C:\tmp\epanet_toolkit_example_vb\epanet_toolkit_example_vb\bin\Debug\epanet2.dll" (ByVal index As Integer, ByVal code As Integer, ByVal v As Single)
    Declare Sub ENaddpattern Lib "C:\tmp\epanet_toolkit_example_vb\epanet_toolkit_example_vb\bin\Debug\epanet2.dll" (ByVal id As String)
    Declare Sub ENsetpattern Lib "C:\tmp\epanet_toolkit_example_vb\epanet_toolkit_example_vb\bin\Debug\epanet2.dll" (ByVal index As Integer, ByRef f As Single, ByVal n As Integer)
    Declare Sub ENsetpatternvalue Lib "C:\tmp\epanet_toolkit_example_vb\epanet_toolkit_example_vb\bin\Debug\epanet2.dll" (ByVal index As Integer, ByVal period As Integer, ByVal value As Single)
    Declare Sub ENsettimeparam Lib "C:\tmp\epanet_toolkit_example_vb\epanet_toolkit_example_vb\bin\Debug\epanet2.dll" (ByVal code As Integer, ByVal value As Single)
    Declare Sub ENsetoption Lib "C:\tmp\epanet_toolkit_example_vb\epanet_toolkit_example_vb\bin\Debug\epanet2.dll" (ByVal code As Integer, ByVal v As Single)
    Declare Sub ENsetstatusreport Lib "C:\tmp\epanet_toolkit_example_vb\epanet_toolkit_example_vb\bin\Debug\epanet2.dll" (ByVal code As Integer)
    Declare Sub ENsetqualtype Lib "C:\tmp\epanet_toolkit_example_vb\epanet_toolkit_example_vb\bin\Debug\epanet2.dll" (ByVal qualcode As Integer, ByVal chemname As String, ByVal chemunits As String, ByVal tracenode As String)
    Declare Sub ENgetheadcurve Lib "C:\tmp\epanet_toolkit_example_vb\epanet_toolkit_example_vb\bin\Debug\epanet2.dll" (ByVal index As Integer, ByVal id As String)
    Declare Sub ENgetpumptype Lib "C:\tmp\epanet_toolkit_example_vb\epanet_toolkit_example_vb\bin\Debug\epanet2.dll" (ByVal index As Integer, ByVal type As Integer)

    ' Node parameters
    Public Const EN_ELEVATION = 0
    Public Const EN_BASEDEMAND = 1
    Public Const EN_PATTERN = 2
    Public Const EN_EMITTER = 3
    Public Const EN_INITQUAL = 4
    Public Const EN_SOURCEQUAL = 5
    Public Const EN_SOURCEPAT = 6
    Public Const EN_SOURCETYPE = 7
    Public Const EN_TANKLEVEL = 8
    Public Const EN_DEMAND = 9
    Public Const EN_HEAD = 10
    Public Const EN_PRESSURE = 11
    Public Const EN_QUALITY = 12
    Public Const EN_SOURCEMASS = 13
    Public Const EN_INITVOLUME = 14
    Public Const EN_MIXMODEL = 15
    Public Const EN_MIXZONEVOL = 16

    Public Const EN_TANKDIAM = 17
    Public Const EN_MINVOLUME = 18
    Public Const EN_VOLCURVE = 19
    Public Const EN_MINLEVEL = 20
    Public Const EN_MAXLEVEL = 21
    Public Const EN_MIXFRACTION = 22
    Public Const EN_TANK_KBULK = 23
    ' Link parameters
    Public Const EN_DIAMETER = 0
    Public Const EN_LENGTH = 1
    Public Const EN_ROUGHNESS = 2
    Public Const EN_MINORLOSS = 3
    Public Const EN_INITSTATUS = 4
    Public Const EN_INITSETTING = 5
    Public Const EN_KBULK = 6
    Public Const EN_KWALL = 7
    Public Const EN_FLOW = 8
    Public Const EN_VELOCITY = 9
    Public Const EN_HEADLOSS = 10
    Public Const EN_STATUS = 11
    Public Const EN_SETTING = 12
    Public Const EN_ENERGY = 13

    ' Time parameters
    Public Const EN_DURATION = 0
    Public Const EN_HYDSTEP = 1
    Public Const EN_QUALSTEP = 2
    Public Const EN_PATTERNSTEP = 3
    Public Const EN_PATTERNSTART = 4
    Public Const EN_REPORTSTEP = 5
    Public Const EN_REPORTSTART = 6
    Public Const EN_RULESTEP = 7
    Public Const EN_STATISTIC = 8
    Public Const EN_PERIODS = 9

    Public Const EN_NODECOUNT = 0
    Public Const EN_TANKCOUNT = 1
    Public Const EN_LINKCOUNT = 2
    Public Const EN_PATCOUNT = 3
    Public Const EN_CURVECOUNT = 4
    Public Const EN_CONTROLCOUNT = 5

    'Node types
    Public Const EN_JUNCTION = 0
    Public Const EN_RESERVOIR = 1
    Public Const EN_TANK = 2

    'Link types
    Public Const EN_CVPIPE = 0
    Public Const EN_PIPE = 1
    Public Const EN_PUMP = 2
    Public Const EN_PRV = 3
    Public Const EN_PSV = 4
    Public Const EN_PBV = 5
    Public Const EN_FCV = 6
    Public Const EN_TCV = 7
    Public Const EN_GPV = 8

    ' Quality analysis types
    Public Const EN_NONE = 0
    Public Const EN_CHEM = 1
    Public Const EN_AGE = 2
    Public Const EN_TRACE = 3

    ' Source quality types
    Public Const EN_CONCEN = 0
    Public Const EN_MASS = 1
    Public Const EN_SETPOINT = 2
    Public Const EN_FLOWPACED = 3

    ' Flow unit types
    Public Const EN_CFS = 0
    Public Const EN_GPM = 1
    Public Const EN_MGD = 2
    Public Const EN_IMGD = 3
    Public Const EN_AFD = 4
    Public Const EN_LPS = 5
    Public Const EN_LPM = 6
    Public Const EN_MLD = 7
    Public Const EN_CMH = 8
    Public Const EN_CMD = 9

    ' Mistc, options
    Public Const EN_TRIALS = 0
    Public Const EN_ACCURACY = 1
    Public Const EN_TOLERANCE = 2
    Public Const EN_EMITEXPON = 3
    Public Const EN_DEMANDMULT = 4

    ' Control types
    Public Const EN_LOWLEVEL = 0
    Public Const EN_HILEVEL = 1
    Public Const EN_TIMER = 2
    Public Const EN_TIMEOFDAY = 3

    'Time statistics types
    Public Const EN_AVERAGE = 1
    Public Const EN_MINIMUM = 2
    Public Const EN_MAXIMUM = 3
    Public Const EN_RANGE = 4

    ' Tank mixing models
    Public Const EN_MIX1 = 0
    Public Const EN_MIX2 = 1
    Public Const EN_FIFO = 2
    Public Const EN_LIFO = 3

    Public Const EN_NOSAVE = 0   ' Save-results-to-file flag
    Public Const EN_SAVE = 1

    Public Const EN_INITFLOW = 10   ' Re-initialize flows flag 

    Public Const EN_CONST_HP = 0   ' constant horsepower          
    Public Const EN_POWER_FUNC = 1 'power function
    Public Const EN_CUSTOM = 2  ' user-defined custom curve


    Sub Main()
        Dim num_nodes As Integer
        Dim num_links As Integer
        Dim t As Integer
        Dim tleft As Integer
        Dim value As Single
        Dim id As String

        Call ENopen("C:\tmp\epanet_toolkit_example_vb\Net1.inp", "", "")
        Call ENgetcount(EN_NODECOUNT, num_nodes)
        Call ENgetcount(EN_LINKCOUNT, num_links)
        ENsolveH()
        ENopenQ()
        ENinitQ(0)

        Do  
            ENrunQ(t)
            For i = 0 To num_nodes - 1 Step 1
                ENgetnodevalue(i, EN_QUALITY, value)
                id = "".PadRight(255, Chr(0))
                ENgetnodeid(i, id)
                id = id.Trim(Chr(0))
                Console.WriteLine("Node " + id + " Quality " + Str(value))
                ENgetnodevalue(i, EN_PRESSURE, value)
                Console.WriteLine("Node " + id + " Pressure " + Str(value))
            Next
            For i = 0 To num_links - 1 Step 1
                ENgetlinkvalue(i, EN_FLOW, value)
                id = "".PadRight(255, Chr(0))
                ENgetlinkid(i, id)
                id = id.Trim(Chr(0))
                Console.WriteLine("Link " + id + " Flow " + Str(value))
            Next
            ENstepQ(tleft)
        Loop Until (tleft = 0)
        ENcloseQ()
        ENsolveQ()
        ENreport()
        ENclose()
    End Sub

End Module
