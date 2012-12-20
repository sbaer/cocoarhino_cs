"""
Post-Build script for RhinoCommon plug-in projects.
Make sure this file is in the same directory as your plug-in
project.  In MonoDevelop under project properties, add the following
to Custom Commands->After Build
  python monobuild.py ${TargetFile}
Also make sure to set your project's build output to build to the MacPlugIns
directory
ex.
/Users/steve/Library/Application Support/McNeel/Rhinoceros/MacPlugIns/HelloMonoPlugIn
"""
import sys, os, string, shutil

oldname = sys.argv[1]
for i in range(2,len(sys.argv)):
    oldname += " " + sys.argv[i]
newname = string.replace(oldname, ".dll", ".rhp")
print "oldname =", oldname
print "newname =", newname
os.rename(oldname, newname)
os.rename(oldname+".mdb", newname+".mdb")
