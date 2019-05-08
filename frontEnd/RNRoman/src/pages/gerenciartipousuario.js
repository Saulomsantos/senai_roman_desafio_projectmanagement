import React, { Component } from 'react';
import { Text, View, StyleSheet } from 'react-native';

class GerenciarTipoUsuario extends Component {
    render() {
        return (
            <View style={styles.container}>
                <Text>Gerenciar Tipo Usuario</Text>
            </View>
        )
    }
}

export default GerenciarTipoUsuario;

const styles = StyleSheet.create({
    container: {
        flex: 1,
        backgroundColor: '#fff',
        alignItems: 'center',
        justifyContent: 'center',
    },
});