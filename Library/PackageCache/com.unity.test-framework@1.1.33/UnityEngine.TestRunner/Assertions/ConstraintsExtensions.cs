n{}'.format(
        ' '.join(cmd), stdout, stderr))
  return ParseManifestFromXml(stdout)


def ParseManifestFromXml(xml_str):
  """Parse an android bundle manifest.

    As ParseManifestFromAapt, but uses the xml output from bundletool. Each
    element is a dict, mapping attribute or children by name. Attributes map to
    a dict (as they are unique), children map to a list of dicts (as there may
    be multiple children with the same name).

  Args:
    xml_str (str) An xml string that is an android manifest.

  Returns:
    A dict holding the parsed manifest, as with ParseManifestFromAapt.
  """
  root = xml.etree.ElementTree.fromstring(xml_str)
  return {root.tag: [_ParseManifestXMLNode(root)]}


def _ParseManifestXMLNode(node):
  out = {}
  for name, value in node.attrib.items():
    cleaned_name = name.replace(
        '{http://schemas.android.com/apk/res/android}',
        'android:').replace(
            '{http://schemas.android.com/tools}',
            'tools:')
    out[cleaned_name] = value
  for child in node:
    out.setdefault(child.tag, []).append(_ParseManifestXMLNode(child))
  return out


def _ParseNumericKey(obj,