using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mediation : MonoBehaviour
{
void Awake()
{
    IronSource.Agent.validateIntegration();
}
}
